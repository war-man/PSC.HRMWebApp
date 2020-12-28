//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 01:49:02 ngay 20/01/2017
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
//using System.Data.EntityClient;
using System.Data.Entity.Core.EntityClient;
//using System.Data.Objects;
using System.Data.Entity.Core.Objects;
//using System.Data.Objects.DataClasses;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace HRMWeb_Business.Model
{
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="QuyetDinh")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class QuyetDinh : ERP_Core.BaseEntityObject//EntityObject
    {
    	static QuyetDinh()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public QuyetDinh()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new QuyetDinh object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static QuyetDinh CreateQuyetDinh(System.Guid oid)
        {
            QuyetDinh quyetDinh = new QuyetDinh();
            quyetDinh.Oid = oid;
            return quyetDinh;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid Oid
        {
            get
            {
                return _oid;
            }
            set
            {
                if (_oid != value)
                {
        			System.Guid oldValue =  _oid;
        			bool stopChanging = false;
                    On_Oid_Changing(oldValue, ref value, ref stopChanging);
                    ReportPropertyChanging("Oid");
        			if(!stopChanging)
        			{
        				_oid = StructuralObject.SetValidValue(value);
        				ReportPropertyChanged("Oid");
        				On_Oid_Changed(oldValue, _oid);//\\
        			}
                }
            }
        }
    	public static String Oid_PropertyName { get { return "Oid"; } }
        private System.Guid _oid;
        partial void On_Oid_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_Oid_Changed(System.Guid oldValue, System.Guid currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<byte> CoQuanRaQuyetDinh
        {
            get
            {
                return _coQuanRaQuyetDinh;
            }
            set
            {
    			Nullable<byte> oldValue =  _coQuanRaQuyetDinh;
    			bool stopChanging = false;
                On_CoQuanRaQuyetDinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CoQuanRaQuyetDinh");
    			if(!stopChanging)
    			{
    				_coQuanRaQuyetDinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CoQuanRaQuyetDinh");
    				On_CoQuanRaQuyetDinh_Changed(oldValue, _coQuanRaQuyetDinh);//\\
    			}
            }
        }
    	public static String CoQuanRaQuyetDinh_PropertyName { get { return "CoQuanRaQuyetDinh"; } }
        private Nullable<byte> _coQuanRaQuyetDinh;
        partial void On_CoQuanRaQuyetDinh_Changing(Nullable<byte> currentValue, ref Nullable<byte> newValue, ref bool stopChanging);
        partial void On_CoQuanRaQuyetDinh_Changed(Nullable<byte> oldValue, Nullable<byte> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> ThongTinTruong
        {
            get
            {
                return _thongTinTruong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _thongTinTruong;
    			bool stopChanging = false;
                On_ThongTinTruong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThongTinTruong");
    			if(!stopChanging)
    			{
    				_thongTinTruong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThongTinTruong");
    				On_ThongTinTruong_Changed(oldValue, _thongTinTruong);//\\
    			}
            }
        }
    	public static String ThongTinTruong_PropertyName { get { return "ThongTinTruong"; } }
        private Nullable<System.Guid> _thongTinTruong;
        partial void On_ThongTinTruong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_ThongTinTruong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenCoQuan
        {
            get
            {
                return _tenCoQuan;
            }
            set
            {
    			string oldValue =  _tenCoQuan;
    			bool stopChanging = false;
                On_TenCoQuan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenCoQuan");
    			if(!stopChanging)
    			{
    				_tenCoQuan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenCoQuan");
    				On_TenCoQuan_Changed(oldValue, _tenCoQuan);//\\
    			}
            }
        }
    	public static String TenCoQuan_PropertyName { get { return "TenCoQuan"; } }
        private string _tenCoQuan;
        partial void On_TenCoQuan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenCoQuan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoQuyetDinh
        {
            get
            {
                return _soQuyetDinh;
            }
            set
            {
    			string oldValue =  _soQuyetDinh;
    			bool stopChanging = false;
                On_SoQuyetDinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoQuyetDinh");
    			if(!stopChanging)
    			{
    				_soQuyetDinh = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoQuyetDinh");
    				On_SoQuyetDinh_Changed(oldValue, _soQuyetDinh);//\\
    			}
            }
        }
    	public static String SoQuyetDinh_PropertyName { get { return "SoQuyetDinh"; } }
        private string _soQuyetDinh;
        partial void On_SoQuyetDinh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoQuyetDinh_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayQuyetDinh
        {
            get
            {
                return _ngayQuyetDinh;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayQuyetDinh;
    			bool stopChanging = false;
                On_NgayQuyetDinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayQuyetDinh");
    			if(!stopChanging)
    			{
    				_ngayQuyetDinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayQuyetDinh");
    				On_NgayQuyetDinh_Changed(oldValue, _ngayQuyetDinh);//\\
    			}
            }
        }
    	public static String NgayQuyetDinh_PropertyName { get { return "NgayQuyetDinh"; } }
        private Nullable<System.DateTime> _ngayQuyetDinh;
        partial void On_NgayQuyetDinh_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayQuyetDinh_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayHieuLuc
        {
            get
            {
                return _ngayHieuLuc;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayHieuLuc;
    			bool stopChanging = false;
                On_NgayHieuLuc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayHieuLuc");
    			if(!stopChanging)
    			{
    				_ngayHieuLuc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayHieuLuc");
    				On_NgayHieuLuc_Changed(oldValue, _ngayHieuLuc);//\\
    			}
            }
        }
    	public static String NgayHieuLuc_PropertyName { get { return "NgayHieuLuc"; } }
        private Nullable<System.DateTime> _ngayHieuLuc;
        partial void On_NgayHieuLuc_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayHieuLuc_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string CanCu
        {
            get
            {
                return _canCu;
            }
            set
            {
    			string oldValue =  _canCu;
    			bool stopChanging = false;
                On_CanCu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CanCu");
    			if(!stopChanging)
    			{
    				_canCu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("CanCu");
    				On_CanCu_Changed(oldValue, _canCu);//\\
    			}
            }
        }
    	public static String CanCu_PropertyName { get { return "CanCu"; } }
        private string _canCu;
        partial void On_CanCu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_CanCu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiDung
        {
            get
            {
                return _noiDung;
            }
            set
            {
    			string oldValue =  _noiDung;
    			bool stopChanging = false;
                On_NoiDung_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiDung");
    			if(!stopChanging)
    			{
    				_noiDung = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiDung");
    				On_NoiDung_Changed(oldValue, _noiDung);//\\
    			}
            }
        }
    	public static String NoiDung_PropertyName { get { return "NoiDung"; } }
        private string _noiDung;
        partial void On_NoiDung_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiDung_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> CapQuyetDinh
        {
            get
            {
                return _capQuyetDinh;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _capQuyetDinh;
    			bool stopChanging = false;
                On_CapQuyetDinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CapQuyetDinh");
    			if(!stopChanging)
    			{
    				_capQuyetDinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CapQuyetDinh");
    				On_CapQuyetDinh_Changed(oldValue, _capQuyetDinh);//\\
    			}
            }
        }
    	public static String CapQuyetDinh_PropertyName { get { return "CapQuyetDinh"; } }
        private Nullable<System.Guid> _capQuyetDinh;
        partial void On_CapQuyetDinh_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_CapQuyetDinh_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<byte> PhanLoaiNguoiKy
        {
            get
            {
                return _phanLoaiNguoiKy;
            }
            set
            {
    			Nullable<byte> oldValue =  _phanLoaiNguoiKy;
    			bool stopChanging = false;
                On_PhanLoaiNguoiKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PhanLoaiNguoiKy");
    			if(!stopChanging)
    			{
    				_phanLoaiNguoiKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PhanLoaiNguoiKy");
    				On_PhanLoaiNguoiKy_Changed(oldValue, _phanLoaiNguoiKy);//\\
    			}
            }
        }
    	public static String PhanLoaiNguoiKy_PropertyName { get { return "PhanLoaiNguoiKy"; } }
        private Nullable<byte> _phanLoaiNguoiKy;
        partial void On_PhanLoaiNguoiKy_Changing(Nullable<byte> currentValue, ref Nullable<byte> newValue, ref bool stopChanging);
        partial void On_PhanLoaiNguoiKy_Changed(Nullable<byte> oldValue, Nullable<byte> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> ChucVuNguoiKy
        {
            get
            {
                return _chucVuNguoiKy;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _chucVuNguoiKy;
    			bool stopChanging = false;
                On_ChucVuNguoiKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChucVuNguoiKy");
    			if(!stopChanging)
    			{
    				_chucVuNguoiKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ChucVuNguoiKy");
    				On_ChucVuNguoiKy_Changed(oldValue, _chucVuNguoiKy);//\\
    			}
            }
        }
    	public static String ChucVuNguoiKy_PropertyName { get { return "ChucVuNguoiKy"; } }
        private Nullable<System.Guid> _chucVuNguoiKy;
        partial void On_ChucVuNguoiKy_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_ChucVuNguoiKy_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> NguoiKy
        {
            get
            {
                return _nguoiKy;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _nguoiKy;
    			bool stopChanging = false;
                On_NguoiKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NguoiKy");
    			if(!stopChanging)
    			{
    				_nguoiKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NguoiKy");
    				On_NguoiKy_Changed(oldValue, _nguoiKy);//\\
    			}
            }
        }
    	public static String NguoiKy_PropertyName { get { return "NguoiKy"; } }
        private Nullable<System.Guid> _nguoiKy;
        partial void On_NguoiKy_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_NguoiKy_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NguoiKy1
        {
            get
            {
                return _nguoiKy1;
            }
            set
            {
    			string oldValue =  _nguoiKy1;
    			bool stopChanging = false;
                On_NguoiKy1_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NguoiKy1");
    			if(!stopChanging)
    			{
    				_nguoiKy1 = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NguoiKy1");
    				On_NguoiKy1_Changed(oldValue, _nguoiKy1);//\\
    			}
            }
        }
    	public static String NguoiKy1_PropertyName { get { return "NguoiKy1"; } }
        private string _nguoiKy1;
        partial void On_NguoiKy1_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NguoiKy1_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> CreateDate
        {
            get
            {
                return _createDate;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _createDate;
    			bool stopChanging = false;
                On_CreateDate_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CreateDate");
    			if(!stopChanging)
    			{
    				_createDate = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CreateDate");
    				On_CreateDate_Changed(oldValue, _createDate);//\\
    			}
            }
        }
    	public static String CreateDate_PropertyName { get { return "CreateDate"; } }
        private Nullable<System.DateTime> _createDate;
        partial void On_CreateDate_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_CreateDate_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NhanVienText
        {
            get
            {
                return _nhanVienText;
            }
            set
            {
    			string oldValue =  _nhanVienText;
    			bool stopChanging = false;
                On_NhanVienText_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NhanVienText");
    			if(!stopChanging)
    			{
    				_nhanVienText = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NhanVienText");
    				On_NhanVienText_Changed(oldValue, _nhanVienText);//\\
    			}
            }
        }
    	public static String NhanVienText_PropertyName { get { return "NhanVienText"; } }
        private string _nhanVienText;
        partial void On_NhanVienText_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NhanVienText_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string BoPhanText
        {
            get
            {
                return _boPhanText;
            }
            set
            {
    			string oldValue =  _boPhanText;
    			bool stopChanging = false;
                On_BoPhanText_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BoPhanText");
    			if(!stopChanging)
    			{
    				_boPhanText = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("BoPhanText");
    				On_BoPhanText_Changed(oldValue, _boPhanText);//\\
    			}
            }
        }
    	public static String BoPhanText_PropertyName { get { return "BoPhanText"; } }
        private string _boPhanText;
        partial void On_BoPhanText_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_BoPhanText_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> OptimisticLockField
        {
            get
            {
                return _optimisticLockField;
            }
            set
            {
    			Nullable<int> oldValue =  _optimisticLockField;
    			bool stopChanging = false;
                On_OptimisticLockField_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("OptimisticLockField");
    			if(!stopChanging)
    			{
    				_optimisticLockField = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("OptimisticLockField");
    				On_OptimisticLockField_Changed(oldValue, _optimisticLockField);//\\
    			}
            }
        }
    	public static String OptimisticLockField_PropertyName { get { return "OptimisticLockField"; } }
        private Nullable<int> _optimisticLockField;
        partial void On_OptimisticLockField_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_OptimisticLockField_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> GCRecord
        {
            get
            {
                return _gCRecord;
            }
            set
            {
    			Nullable<int> oldValue =  _gCRecord;
    			bool stopChanging = false;
                On_GCRecord_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GCRecord");
    			if(!stopChanging)
    			{
    				_gCRecord = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("GCRecord");
    				On_GCRecord_Changed(oldValue, _gCRecord);//\\
    			}
            }
        }
    	public static String GCRecord_PropertyName { get { return "GCRecord"; } }
        private Nullable<int> _gCRecord;
        partial void On_GCRecord_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_GCRecord_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> ObjectType
        {
            get
            {
                return _objectType;
            }
            set
            {
    			Nullable<int> oldValue =  _objectType;
    			bool stopChanging = false;
                On_ObjectType_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ObjectType");
    			if(!stopChanging)
    			{
    				_objectType = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ObjectType");
    				On_ObjectType_Changed(oldValue, _objectType);//\\
    			}
            }
        }
    	public static String ObjectType_PropertyName { get { return "ObjectType"; } }
        private Nullable<int> _objectType;
        partial void On_ObjectType_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_ObjectType_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> DaCapNhat
        {
            get
            {
                return _daCapNhat;
            }
            set
            {
    			Nullable<int> oldValue =  _daCapNhat;
    			bool stopChanging = false;
                On_DaCapNhat_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DaCapNhat");
    			if(!stopChanging)
    			{
    				_daCapNhat = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DaCapNhat");
    				On_DaCapNhat_Changed(oldValue, _daCapNhat);//\\
    			}
            }
        }
    	public static String DaCapNhat_PropertyName { get { return "DaCapNhat"; } }
        private Nullable<int> _daCapNhat;
        partial void On_DaCapNhat_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_DaCapNhat_Changed(Nullable<int> oldValue, Nullable<int> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuyetDinh_ChucVuNguoiKy", "ChucVu")]
        public ChucVu ChucVu
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ChucVu>("ERPModel.FK_QuyetDinh_ChucVuNguoiKy", "ChucVu").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_ChucVu_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ChucVu>("ERPModel.FK_QuyetDinh_ChucVuNguoiKy", "ChucVu").Value = value;
    				On_ChucVu_Changed(this.ChucVu);//\\//
    			}
    	    }
        }
    	public static String ChucVu_ReferencePropertyName { get { return "ChucVu"; } }
    	partial void On_ChucVu_Changing(ref ChucVu newValue, ref bool stopChanging);
    	partial void On_ChucVu_Changed(ChucVu currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ChucVu> ChucVuReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ChucVu>("ERPModel.FK_QuyetDinh_ChucVuNguoiKy", "ChucVu");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ChucVu>("ERPModel.FK_QuyetDinh_ChucVuNguoiKy", "ChucVu", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuyetDinh_NguoiKy", "ThongTinNhanVien")]
        public ThongTinNhanVien ThongTinNhanVien
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_QuyetDinh_NguoiKy", "ThongTinNhanVien").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_ThongTinNhanVien_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_QuyetDinh_NguoiKy", "ThongTinNhanVien").Value = value;
    				On_ThongTinNhanVien_Changed(this.ThongTinNhanVien);//\\//
    			}
    	    }
        }
    	public static String ThongTinNhanVien_ReferencePropertyName { get { return "ThongTinNhanVien"; } }
    	partial void On_ThongTinNhanVien_Changing(ref ThongTinNhanVien newValue, ref bool stopChanging);
    	partial void On_ThongTinNhanVien_Changed(ThongTinNhanVien currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ThongTinNhanVien> ThongTinNhanVienReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_QuyetDinh_NguoiKy", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ThongTinNhanVien>("ERPModel.FK_QuyetDinh_NguoiKy", "ThongTinNhanVien", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuyetDinhCaNhan_Oid", "QuyetDinhCaNhan")]
        public QuyetDinhCaNhan QuyetDinhCaNhan
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuyetDinhCaNhan>("ERPModel.FK_QuyetDinhCaNhan_Oid", "QuyetDinhCaNhan").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_QuyetDinhCaNhan_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuyetDinhCaNhan>("ERPModel.FK_QuyetDinhCaNhan_Oid", "QuyetDinhCaNhan").Value = value;
    				On_QuyetDinhCaNhan_Changed(this.QuyetDinhCaNhan);//\\//
    			}
    	    }
        }
    	public static String QuyetDinhCaNhan_ReferencePropertyName { get { return "QuyetDinhCaNhan"; } }
    	partial void On_QuyetDinhCaNhan_Changing(ref QuyetDinhCaNhan newValue, ref bool stopChanging);
    	partial void On_QuyetDinhCaNhan_Changed(QuyetDinhCaNhan currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<QuyetDinhCaNhan> QuyetDinhCaNhanReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuyetDinhCaNhan>("ERPModel.FK_QuyetDinhCaNhan_Oid", "QuyetDinhCaNhan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<QuyetDinhCaNhan>("ERPModel.FK_QuyetDinhCaNhan_Oid", "QuyetDinhCaNhan", value);
                }
            }
        }

        #endregion

    }
}
