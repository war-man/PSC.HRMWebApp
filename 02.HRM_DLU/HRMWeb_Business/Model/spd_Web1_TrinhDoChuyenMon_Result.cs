//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi SERVERERP\tai luc 05:27:30 ngay 19/04/2017
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_TrinhDoChuyenMon_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_TrinhDoChuyenMon_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TrinhDoHocVan
        {
            get
            {
                return _trinhDoHocVan;
            }
            set
            {
    			string oldValue =  _trinhDoHocVan;
    			bool stopChanging = false;
                On_TrinhDoHocVan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TrinhDoHocVan");
    			if(!stopChanging)
    			{
    				_trinhDoHocVan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TrinhDoHocVan");
    				On_TrinhDoHocVan_Changed(oldValue, _trinhDoHocVan);//\\
    			}
            }
        }
    	public static String TrinhDoHocVan_PropertyName { get { return "TrinhDoHocVan"; } }
        private string _trinhDoHocVan;
        partial void On_TrinhDoHocVan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TrinhDoHocVan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TrinhDoChuyenMonCaoNhat
        {
            get
            {
                return _trinhDoChuyenMonCaoNhat;
            }
            set
            {
    			string oldValue =  _trinhDoChuyenMonCaoNhat;
    			bool stopChanging = false;
                On_TrinhDoChuyenMonCaoNhat_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TrinhDoChuyenMonCaoNhat");
    			if(!stopChanging)
    			{
    				_trinhDoChuyenMonCaoNhat = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TrinhDoChuyenMonCaoNhat");
    				On_TrinhDoChuyenMonCaoNhat_Changed(oldValue, _trinhDoChuyenMonCaoNhat);//\\
    			}
            }
        }
    	public static String TrinhDoChuyenMonCaoNhat_PropertyName { get { return "TrinhDoChuyenMonCaoNhat"; } }
        private string _trinhDoChuyenMonCaoNhat;
        partial void On_TrinhDoChuyenMonCaoNhat_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TrinhDoChuyenMonCaoNhat_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChuyenNganhDaoTao
        {
            get
            {
                return _chuyenNganhDaoTao;
            }
            set
            {
    			string oldValue =  _chuyenNganhDaoTao;
    			bool stopChanging = false;
                On_ChuyenNganhDaoTao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChuyenNganhDaoTao");
    			if(!stopChanging)
    			{
    				_chuyenNganhDaoTao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChuyenNganhDaoTao");
    				On_ChuyenNganhDaoTao_Changed(oldValue, _chuyenNganhDaoTao);//\\
    			}
            }
        }
    	public static String ChuyenNganhDaoTao_PropertyName { get { return "ChuyenNganhDaoTao"; } }
        private string _chuyenNganhDaoTao;
        partial void On_ChuyenNganhDaoTao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChuyenNganhDaoTao_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TruongDaoTao
        {
            get
            {
                return _truongDaoTao;
            }
            set
            {
    			string oldValue =  _truongDaoTao;
    			bool stopChanging = false;
                On_TruongDaoTao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TruongDaoTao");
    			if(!stopChanging)
    			{
    				_truongDaoTao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TruongDaoTao");
    				On_TruongDaoTao_Changed(oldValue, _truongDaoTao);//\\
    			}
            }
        }
    	public static String TruongDaoTao_PropertyName { get { return "TruongDaoTao"; } }
        private string _truongDaoTao;
        partial void On_TruongDaoTao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TruongDaoTao_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string HinhThucDaoTao
        {
            get
            {
                return _hinhThucDaoTao;
            }
            set
            {
    			string oldValue =  _hinhThucDaoTao;
    			bool stopChanging = false;
                On_HinhThucDaoTao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HinhThucDaoTao");
    			if(!stopChanging)
    			{
    				_hinhThucDaoTao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("HinhThucDaoTao");
    				On_HinhThucDaoTao_Changed(oldValue, _hinhThucDaoTao);//\\
    			}
            }
        }
    	public static String HinhThucDaoTao_PropertyName { get { return "HinhThucDaoTao"; } }
        private string _hinhThucDaoTao;
        partial void On_HinhThucDaoTao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_HinhThucDaoTao_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> NamTotNghiep
        {
            get
            {
                return _namTotNghiep;
            }
            set
            {
    			Nullable<int> oldValue =  _namTotNghiep;
    			bool stopChanging = false;
                On_NamTotNghiep_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NamTotNghiep");
    			if(!stopChanging)
    			{
    				_namTotNghiep = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NamTotNghiep");
    				On_NamTotNghiep_Changed(oldValue, _namTotNghiep);//\\
    			}
            }
        }
    	public static String NamTotNghiep_PropertyName { get { return "NamTotNghiep"; } }
        private Nullable<int> _namTotNghiep;
        partial void On_NamTotNghiep_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_NamTotNghiep_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string HocHam
        {
            get
            {
                return _hocHam;
            }
            set
            {
    			string oldValue =  _hocHam;
    			bool stopChanging = false;
                On_HocHam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HocHam");
    			if(!stopChanging)
    			{
    				_hocHam = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("HocHam");
    				On_HocHam_Changed(oldValue, _hocHam);//\\
    			}
            }
        }
    	public static String HocHam_PropertyName { get { return "HocHam"; } }
        private string _hocHam;
        partial void On_HocHam_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_HocHam_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NamCongNhan
        {
            get
            {
                return _namCongNhan;
            }
            set
            {
    			string oldValue =  _namCongNhan;
    			bool stopChanging = false;
                On_NamCongNhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NamCongNhan");
    			if(!stopChanging)
    			{
    				_namCongNhan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NamCongNhan");
    				On_NamCongNhan_Changed(oldValue, _namCongNhan);//\\
    			}
            }
        }
    	public static String NamCongNhan_PropertyName { get { return "NamCongNhan"; } }
        private string _namCongNhan;
        partial void On_NamCongNhan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NamCongNhan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DangTheoHoc
        {
            get
            {
                return _dangTheoHoc;
            }
            set
            {
    			string oldValue =  _dangTheoHoc;
    			bool stopChanging = false;
                On_DangTheoHoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DangTheoHoc");
    			if(!stopChanging)
    			{
    				_dangTheoHoc = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DangTheoHoc");
    				On_DangTheoHoc_Changed(oldValue, _dangTheoHoc);//\\
    			}
            }
        }
    	public static String DangTheoHoc_PropertyName { get { return "DangTheoHoc"; } }
        private string _dangTheoHoc;
        partial void On_DangTheoHoc_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DangTheoHoc_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string LyLuanChinhTri
        {
            get
            {
                return _lyLuanChinhTri;
            }
            set
            {
    			string oldValue =  _lyLuanChinhTri;
    			bool stopChanging = false;
                On_LyLuanChinhTri_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LyLuanChinhTri");
    			if(!stopChanging)
    			{
    				_lyLuanChinhTri = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("LyLuanChinhTri");
    				On_LyLuanChinhTri_Changed(oldValue, _lyLuanChinhTri);//\\
    			}
            }
        }
    	public static String LyLuanChinhTri_PropertyName { get { return "LyLuanChinhTri"; } }
        private string _lyLuanChinhTri;
        partial void On_LyLuanChinhTri_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_LyLuanChinhTri_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QuanLyNhaNuoc
        {
            get
            {
                return _quanLyNhaNuoc;
            }
            set
            {
    			string oldValue =  _quanLyNhaNuoc;
    			bool stopChanging = false;
                On_QuanLyNhaNuoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanLyNhaNuoc");
    			if(!stopChanging)
    			{
    				_quanLyNhaNuoc = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QuanLyNhaNuoc");
    				On_QuanLyNhaNuoc_Changed(oldValue, _quanLyNhaNuoc);//\\
    			}
            }
        }
    	public static String QuanLyNhaNuoc_PropertyName { get { return "QuanLyNhaNuoc"; } }
        private string _quanLyNhaNuoc;
        partial void On_QuanLyNhaNuoc_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QuanLyNhaNuoc_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QuanLyKinhTe
        {
            get
            {
                return _quanLyKinhTe;
            }
            set
            {
    			string oldValue =  _quanLyKinhTe;
    			bool stopChanging = false;
                On_QuanLyKinhTe_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanLyKinhTe");
    			if(!stopChanging)
    			{
    				_quanLyKinhTe = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QuanLyKinhTe");
    				On_QuanLyKinhTe_Changed(oldValue, _quanLyKinhTe);//\\
    			}
            }
        }
    	public static String QuanLyKinhTe_PropertyName { get { return "QuanLyKinhTe"; } }
        private string _quanLyKinhTe;
        partial void On_QuanLyKinhTe_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QuanLyKinhTe_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QuanLyGiaoDuc
        {
            get
            {
                return _quanLyGiaoDuc;
            }
            set
            {
    			string oldValue =  _quanLyGiaoDuc;
    			bool stopChanging = false;
                On_QuanLyGiaoDuc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanLyGiaoDuc");
    			if(!stopChanging)
    			{
    				_quanLyGiaoDuc = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QuanLyGiaoDuc");
    				On_QuanLyGiaoDuc_Changed(oldValue, _quanLyGiaoDuc);//\\
    			}
            }
        }
    	public static String QuanLyGiaoDuc_PropertyName { get { return "QuanLyGiaoDuc"; } }
        private string _quanLyGiaoDuc;
        partial void On_QuanLyGiaoDuc_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QuanLyGiaoDuc_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TrinhDoTinHoc
        {
            get
            {
                return _trinhDoTinHoc;
            }
            set
            {
    			string oldValue =  _trinhDoTinHoc;
    			bool stopChanging = false;
                On_TrinhDoTinHoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TrinhDoTinHoc");
    			if(!stopChanging)
    			{
    				_trinhDoTinHoc = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TrinhDoTinHoc");
    				On_TrinhDoTinHoc_Changed(oldValue, _trinhDoTinHoc);//\\
    			}
            }
        }
    	public static String TrinhDoTinHoc_PropertyName { get { return "TrinhDoTinHoc"; } }
        private string _trinhDoTinHoc;
        partial void On_TrinhDoTinHoc_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TrinhDoTinHoc_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgoaiNguChinh
        {
            get
            {
                return _ngoaiNguChinh;
            }
            set
            {
    			string oldValue =  _ngoaiNguChinh;
    			bool stopChanging = false;
                On_NgoaiNguChinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgoaiNguChinh");
    			if(!stopChanging)
    			{
    				_ngoaiNguChinh = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgoaiNguChinh");
    				On_NgoaiNguChinh_Changed(oldValue, _ngoaiNguChinh);//\\
    			}
            }
        }
    	public static String NgoaiNguChinh_PropertyName { get { return "NgoaiNguChinh"; } }
        private string _ngoaiNguChinh;
        partial void On_NgoaiNguChinh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgoaiNguChinh_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TrinhDoNgoaiNguChinh
        {
            get
            {
                return _trinhDoNgoaiNguChinh;
            }
            set
            {
    			string oldValue =  _trinhDoNgoaiNguChinh;
    			bool stopChanging = false;
                On_TrinhDoNgoaiNguChinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TrinhDoNgoaiNguChinh");
    			if(!stopChanging)
    			{
    				_trinhDoNgoaiNguChinh = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TrinhDoNgoaiNguChinh");
    				On_TrinhDoNgoaiNguChinh_Changed(oldValue, _trinhDoNgoaiNguChinh);//\\
    			}
            }
        }
    	public static String TrinhDoNgoaiNguChinh_PropertyName { get { return "TrinhDoNgoaiNguChinh"; } }
        private string _trinhDoNgoaiNguChinh;
        partial void On_TrinhDoNgoaiNguChinh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TrinhDoNgoaiNguChinh_Changed(string oldValue, string currentValue);

    #endregion

    }
}
