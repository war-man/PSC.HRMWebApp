﻿
define(['app/app', 'app/services/abc/ABC_CriterionService', 'app/services/abc/ABC_RatingTypeService'], function (app) {
    "use strict";

    //var HRMWebAppModule = angular.module('HRMWebApp');

    app.controller('ABC_CriterionController', ['$scope', '$rootScope', '$modal', 'ABC_CriterionService',
            function ($scope, $rootScope, $modal, ABC_CriterionService) {

                $scope.grid = {};
                $scope.isEdit = false;
                $scope.RatingType = MANAGER.GUID_EMPTY;

                $scope.$on("RATINGTYPESELECTION", function (event, args) {
                    $scope.RatingType = args;
                    $scope.dataSource.read();
                });

                $scope.dataSource = new kendo.data.DataSource({
                    transport: {
                        read: function (options) {
                            return ABC_CriterionService.getListByRatingType($scope.RatingType).then(function (result) {
                                options.success(result.data);
                            });
                        }
                    },
                    pageSize: 20
                });

                $scope.mainGridOptions = {
                    sortable: true,
                    pageable: true,
                    selectable: true,
                    columns: [{
                        template: "<div style='text-align:center'>#:data.OrderNumber #</div>",
                        width: "50px",
                        title: "STT"
                    },{
                        field: "Name",
                        title: "Tiêu chí đánh giá"
                    },
                    {
                        template: "<div style='width: 30px;'><button ng-click='Edit(\"#:data.Id #\")' class='btn btn-block btn-success btn-xs'><i class='fa fa-pencil'></i>  </button></div>",
                        width: "50px"
                    },
                    {
                        template: "<div style='width: 30px;'><button ng-click='Delete(\"#:data.Id #\")' class='btn btn-block btn-danger btn-xs'><i class='fa fa-times'></i>  </button></div>",
                        width: "50px",
                    }],
                };

                $scope.New = function () {
                    $scope.isEdit = false;
                    var modalInstance = $modal.open({
                        animation: true,
                        templateUrl: '/app/views/abc/ABC_Criterion/detail.html',
                        controller: 'ABC_CriterionDetailController',
                        size: 'lg',
                        resolve: {
                            id: function () {
                                return MANAGER.GUID_EMPTY;
                            }
                        }
                    }).result.then(function (result) {
                        $scope.grid.dataSource.read();
                    });
                };

                $scope.Edit = function (Id) {
                    if (Id == "") {
                        alert("Bạn chưa chọn phần tử");
                        return;
                    }

                    var modalInstance = $modal.open({
                        animation: true,
                        templateUrl: '/app/views/abc/ABC_Criterion/detail.html',
                        controller: 'ABC_CriterionDetailController',
                        size: 'lg',
                        resolve: {
                            id: function () {
                                return Id;
                            },
                        }
                    }).result.then(function () {
                        $scope.grid.dataSource.read();
                    });
                }

                $scope.Delete = function (Id) {
                    if (Id == "") {
                        alert("Bạn chưa chọn phần tử");
                        return;
                    }
                    ABC_CriterionService.getCheckHasCriterionDetail(Id).then(function (result) {
                        var check = result.data;
                        if (check==true)
                        {
                            alert("Tiêu chí này đã có tiêu chí con, xóa các tiêu chí con trước mới có thể xóa tiêu chí này!");
                            return;
                        }
                        else
                        {
                            var valid = window.confirm("Bạn có thật sự muốn xóa không?");
                            if (!valid)
                                return;
                            ABC_CriterionService.getCriterionById(Id).then(function (result) {
                                ABC_CriterionService.DeleteCriterion(result.data).then(function (result1) {
                                    if (result1 == 0)
                                    {
                                        Notify('Xóa thất bại!', 'top-right', '3000', 'error', 'fa-times', true);
                                    }
                                    else if (result1 == 1)
                                    {
                                        Notify('Xóa thành công!', 'top-right', '3000', 'success', 'fa-check', true);
                                    }

                                    $scope.grid.dataSource.read();
                                });
                            });
                        }
                    });                   
                };
            }
    ]);

    app.controller('ABC_CriterionDetailController', ['$scope', '$modal', '$modalInstance', 'id', 'ABC_CriterionService', 'ABC_RatingTypeService',
    function ($scope, $modal, $modalInstance, id, ABC_CriterionService, ABC_RatingTypeService) {
        $scope.isNew = id == MANAGER.GUID_EMPTY || '' ? true : false;
        $scope.options = {
            format: "n0",
            max: 100
        };
        $scope.criterionId = id;
        $scope.type = 0;
        $scope.obj = {};
        $scope.criterionTypes = [
            {
                Id: 0,
                Name: "Tiêu chí đánh giá chung"
            },
            {
                Id: 1,
                Name: "Điểm phạt riêng cho NV"
            },
            {
                Id: 2,
                Name: "Tiêu chí đánh giá riêng cho NV"
            },
            {
                Id: 3,
                Name: "Tiêu chí đánh giá riêng cho GV"
            },
            {
                Id: 4,
                Name: "Điểm phạt riêng cho GV"
            },
            {
                Id: 5,
                Name: " Điểm thưởng chung và quy định hoàn thành nhiệm vụ chung"
            },
        ]

        $scope.dataSource = new kendo.data.DataSource({
            transport: {
                read: function (options) {
                    return ABC_CriterionService.getListCriterionDetailByCriterionId($scope.criterionId).then(function (result) {
                        options.success(result.data);
                    });
                }
            },
            pageSize: 20
        });

        $scope.mainDictionaryGridOptions = {
            sortable: true,
            pageable: true,
            selectable: true,
            columns: [{
                field: "Name",
                title: "Nội dung",
                attributes: {
                    style: "white-space: pre-wrap"
                }
            },
            {
                field: "MaxRecord",
                title: "Điểm tối đa",
                width: "100px"
            },
            {
                template: "<div style='width: 30px;'><button ng-click='EditCriterionDetail(\"#:data.Id #\")' class='btn btn-block btn-success btn-xs'><i class='fa fa-pencil'></i>  </button></div>",
                width: "50px"
            },
            {
                template: "<div style='width: 30px;'><button ng-click='DeleteCriterionDetail(\"#:data.Id #\")' class='btn btn-block btn-danger btn-xs'><i class='fa fa-times'></i>  </button></div>",
                width: "50px",
            }],
        };
        
        $scope.title = "Chi tiết nhóm tiêu chí đánh giá";
        if ($scope.isNew)
        {
           $scope.obj =
            {
                Id: MANAGER.GUID_EMPTY,
                Name: ""
            };      
        }
        else
        {
            ABC_CriterionService.getCriterionById(id).then(function (result) {
                $scope.obj = result.data;
            });
        }

        $scope.selectOptions = {
            placeholder: "",
            dataTextField: "Name",
            dataValueField: "Id",
            valuePrimitive: true,
            filter: "contains",
            autoBind: false,
            dataSource: {
                transport: {
                    read: function (options) {
                        ABC_RatingTypeService.getList().then(function (result) {
                            options.success(result.data);
                        });
                    }
                }
            }
        };

        $scope.selectOptions2 = {
            placeholder: "",
            dataTextField: "Name",
            dataValueField: "Id",
            valuePrimitive: true,
            autoBind: false,
            dataSource: {
                transport: {
                    read: function (options) {
                        ABC_RatingTypeService.getList().then(function (result) {
                            options.success(result.data.filter(ratingType => ratingType.Id != $scope.obj.ABC_RatingTypeDTO.Id));
                        });
                    }
                }
            }
        };

        $scope.save = function () {
            if ($scope.isNew) {
                ABC_CriterionService.SaveCriterion($scope.obj).then(function (result) {
                    $modalInstance.close();
                });
            } else {
                ABC_CriterionService.SaveCriterion($scope.obj).then(function (result) {
                    ABC_CriterionService.saveCriterionDetailsOfCriterionCopys(result).then(function () {
                        $modalInstance.close();
                    });
                });
            }
        };

        $scope.cancel = function () {
            $modalInstance.dismiss('cancel');
        };
        //CriterionDetail:
        $scope.NewCriterionDetail = function () {
            var modalInstance = $modal.open({
                animation: true,
                templateUrl: '/app/views/abc/ABC_Criterion/criterionDetail.html',
                controller: 'ABC_CriterionDetailInformationController',
                resolve: {
                    id: function () {
                        return MANAGER.GUID_EMPTY;1
                    },
                    criterionId: function () {
                        return $scope.criterionId;
                    }
                }
            }).result.then(function (result) {
                $scope.grid.dataSource.read();
            });
        }

        $scope.EditCriterionDetail = function (dictionaryId) {
            if (dictionaryId == "") {
                alert("Bạn chưa chọn phần tử");
                return;
            }

            var modalInstance = $modal.open({
                animation: true,
                templateUrl: '/app/views/abc/ABC_Criterion/criterionDetail.html',
                controller: 'ABC_CriterionDetailInformationController',
                resolve: {
                    id: function () {
                        return dictionaryId;
                    },
                    criterionId: function () {
                        return $scope.criterionId;
                    },
                    type: function () {
                        return $scope.type;
                    }
                }
            }).result.then(function () {
                $scope.grid.dataSource.read();
            });
        }

        $scope.DeleteCriterionDetail = function (Id) {
            if (Id == "") {
                alert("Bạn chưa chọn phần tử");
                return;
            }
            var valid = window.confirm("Bạn có thật sự muốn xóa không?");
            if (!valid)
                return;
            ABC_CriterionService.getCriterionDetailById(Id).then(function (result) {
                ABC_CriterionService.DeleteCriterionDetail(result.data).then(function (data) {
                    if (data == 0) {
                        alert("Không thể xóa tiêu chí đã có kết quả đánh giá");
                    }
                    $scope.grid.dataSource.read();
                });
            });
        };
    
    }]);

    app.controller('ABC_CriterionDetailInformationController', ['$scope', '$modal', '$modalInstance', 'id','criterionId', 'ABC_CriterionService',
    function ($scope, $modal, $modalInstance, id,criterionId, ABC_CriterionService) {
        $scope.isNew = id == MANAGER.GUID_EMPTY || '' ? true : false;
        $scope.options = {
            format: "n0",
            max: 100
        };
        $scope.criterionId = criterionId;
        $scope.criterionDetailId = id;
        $scope.type = 0;
        $scope.obj = {};
        ABC_CriterionService.getListCriterionDetailType().then(function (result) {
            $scope.criterionDetailTypes = result.data;
        });

        $scope.title = "Tiêu chí đánh giá";
        if ($scope.isNew) {
            $scope.obj =
             {
                 Id: MANAGER.GUID_EMPTY,
                 Name: "",
                 ABC_CriterionId: $scope.criterionId
             };
        }
        else {
            ABC_CriterionService.getCriterionDetailById(id).then(function (result) {
                $scope.obj = result.data;
            });
        }

        $scope.saveCriterionDetail = function () {
            ABC_CriterionService.SaveCriterionDetail($scope.obj).then(function () {
                $modalInstance.close();
            });
        };

        $scope.cancel = function () {
            $modalInstance.dismiss('cancel');
        };   

    }]);
});