﻿
define(['app/app', 'app/services/kpi/menuRoleService'], function (app) {
    "use strict";

    app.controller('menuRoleController', ['$scope', '$modal', '$rootScope', 'menuRoleService',
            function ($scope, $modal, $rootScope, menuRoleService) {
                $scope.createWidget = false;
                $scope.grid = {};
                $scope.isEdit = false;
                $scope.resultList = [];
                $scope.dataSource = new kendo.data.TreeListDataSource({
                    transport: {
                        read: function (options) {
                            return menuRoleService.getWebMenuTreeList().then(function (result) {
                                options.success(result.data);
                            });
                        }
                    },
                    schema: {
                        model: {
                            id: "Id",
                            fields: {
                                parentId: { field: "ParentId", nullable: true },
                                Id: { field: "Id", type: "string" }
                            },
                            expanded: true
                        }

                    }
                });
                $scope.mainGridOptions = {
                    sortable: true,
                    filterable: {
                        messages: {
                            info: dataLocalize("QUAN_LY_MENU_VA_PHAN_QUYEN.QUAN_LY_MENU.LOC_BOI"),
                            filter: dataLocalize("QUAN_LY_MENU_VA_PHAN_QUYEN.QUAN_LY_MENU.LOC"),
                            clear: dataLocalize("QUAN_LY_MENU_VA_PHAN_QUYEN.QUAN_LY_MENU.XOA")
                        },
                        extra: false,
                        operators: {
                            string: {
                                contains: dataLocalize("QUAN_LY_MENU_VA_PHAN_QUYEN.QUAN_LY_MENU.TU_KHOA")
                            }
                        }
                    },
                    columns: [{ field: "Name", title: dataLocalize("QUAN_LY_MENU_VA_PHAN_QUYEN.QUAN_LY_MENU.DANH_SACH_MENU") },
                    {
                        template: "<div style='width: 30px;'><button ng-click='Edit(\"#:data.Id #\")' class='btn btn-block btn-success btn-xs'><i class='fa fa-pencil'></i>  </button></div>",
                        width: "50px"
                    }],
                };
                $scope.Edit = function (Id) {

                    if (Id == "") {
                        alert(dataLocalize("QUAN_LY_MENU_VA_PHAN_QUYEN.QUAN_LY_MENU.ALERT.BAN_CHUA_CHON_PHAN_TU"));
                        return;
                    }
                    var modalInstance = $modal.open({
                        animation: true,
                        templateUrl: '/app/views/kpi/menuRole/detail.html',
                        controller: 'menuRoleDetailController',
                        resolve: {
                            id: function () {
                                return Id;
                            }
                        }
                    }).result.then(function () {
                        menuRoleService.getWebMenuTreeList().then(function (result) {
                            $scope.grid.dataSource.read();
                        });
                    });
                };
            }
    ]);
    app.controller('menuRoleDetailController', ['$scope', '$modalInstance', 'id', 'menuRoleService',
        function ($scope, $modalInstance, id, menuRoleService) {

            $scope.title = dataLocalize("QUAN_LY_MENU_VA_PHAN_QUYEN.QUAN_LY_MENU.EDIT.QUAN_LY");
            $scope.obj = {};
            $scope.parentMenuList = {};
            $scope.options = {
                format: "n0",
                min: 0
            }
            menuRoleService.getObject(id).then(function (result) {
                $scope.obj = result.data;
                $scope.hasParent = $scope.obj.ParentId == MANAGER.GUID_EMPTY ? 0 : 1;
                });
            menuRoleService.getListParentMenu().then(function (result) {
                    $scope.parentMenuList = result.data;
                });
            $scope.save = function () {
                menuRoleService.Save($scope.obj).then(function (result) {
                    if (result == 1)
                    {
                        alert(dataLocalize("QUAN_LY_MENU_VA_PHAN_QUYEN.QUAN_LY_MENU.ALERT.THANH_CONG"));
                        $modalInstance.close();
                    }
                    else
                    {
                        alert(dataLocalize("QUAN_LY_MENU_VA_PHAN_QUYEN.QUAN_LY_MENU.ALERT.THAT_BAI"));
                    }
                       
                    });
            };

            $scope.cancel = function () {
                $modalInstance.dismiss('cancel');
            };
        }
    ]);
});