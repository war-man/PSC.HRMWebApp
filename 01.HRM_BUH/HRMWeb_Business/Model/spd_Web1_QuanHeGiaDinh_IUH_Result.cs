//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-O8ODB0C\thevi luc 09:44:28 ngay 17/09/2019
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuanHeGiaDinh_IUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuanHeGiaDinh_IUH_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web1_QuanHeGiaDinh_IUH_Result object.
        /// </summary>
        /// <param name="gioiTinh">Initial value of the GioiTinh property.</param>
        /// <param name="tinhTrang">Initial value of the TinhTrang property.</param>
        public static spd_Web1_QuanHeGiaDinh_IUH_Result Createspd_Web1_QuanHeGiaDinh_IUH_Result(string gioiTinh, string tinhTrang)
        {
            spd_Web1_QuanHeGiaDinh_IUH_Result spd_Web1_QuanHeGiaDinh_IUH_Result = new spd_Web1_QuanHeGiaDinh_IUH_Result();
            spd_Web1_QuanHeGiaDinh_IUH_Result.GioiTinh = gioiTinh;
            spd_Web1_QuanHeGiaDinh_IUH_Result.TinhTrang = tinhTrang;
            return spd_Web1_QuanHeGiaDinh_IUH_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string HoTen
        {
            get
            {
                return _hoTen;
            }
            set
            {
    			string oldValue =  _hoTen;
    			bool stopChanging = false;
                On_HoTen_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HoTen");
    			if(!stopChanging)
    			{
    				_hoTen = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("HoTen");
    				On_HoTen_Changed(oldValue, _hoTen);//\\
    			}
            }
        }
    	public static String HoTen_PropertyName { get { return "HoTen"; } }
        private string _hoTen;
        partial void On_HoTen_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_HoTen_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string GioiTinh
        {
            get
            {
                return _gioiTinh;
            }
            set
            {
    			string oldValue =  _gioiTinh;
    			bool stopChanging = false;
                On_GioiTinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GioiTinh");
    			if(!stopChanging)
    			{
    				_gioiTinh = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("GioiTinh");
    				On_GioiTinh_Changed(oldValue, _gioiTinh);//\\
    			}
            }
        }
    	public static String GioiTinh_PropertyName { get { return "GioiTinh"; } }
        private string _gioiTinh;
        partial void On_GioiTinh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_GioiTinh_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> NamSinh
        {
            get
            {
                return _namSinh;
            }
            set
            {
    			Nullable<int> oldValue =  _namSinh;
    			bool stopChanging = false;
                On_NamSinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NamSinh");
    			if(!stopChanging)
    			{
    				_namSinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NamSinh");
    				On_NamSinh_Changed(oldValue, _namSinh);//\\
    			}
            }
        }
    	public static String NamSinh_PropertyName { get { return "NamSinh"; } }
        private Nullable<int> _namSinh;
        partial void On_NamSinh_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_NamSinh_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QuanHe
        {
            get
            {
                return _quanHe;
            }
            set
            {
    			string oldValue =  _quanHe;
    			bool stopChanging = false;
                On_QuanHe_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanHe");
    			if(!stopChanging)
    			{
    				_quanHe = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QuanHe");
    				On_QuanHe_Changed(oldValue, _quanHe);//\\
    			}
            }
        }
    	public static String QuanHe_PropertyName { get { return "QuanHe"; } }
        private string _quanHe;
        partial void On_QuanHe_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QuanHe_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DanToc
        {
            get
            {
                return _danToc;
            }
            set
            {
    			string oldValue =  _danToc;
    			bool stopChanging = false;
                On_DanToc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DanToc");
    			if(!stopChanging)
    			{
    				_danToc = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DanToc");
    				On_DanToc_Changed(oldValue, _danToc);//\\
    			}
            }
        }
    	public static String DanToc_PropertyName { get { return "DanToc"; } }
        private string _danToc;
        partial void On_DanToc_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DanToc_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TonGiao
        {
            get
            {
                return _tonGiao;
            }
            set
            {
    			string oldValue =  _tonGiao;
    			bool stopChanging = false;
                On_TonGiao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TonGiao");
    			if(!stopChanging)
    			{
    				_tonGiao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TonGiao");
    				On_TonGiao_Changed(oldValue, _tonGiao);//\\
    			}
            }
        }
    	public static String TonGiao_PropertyName { get { return "TonGiao"; } }
        private string _tonGiao;
        partial void On_TonGiao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TonGiao_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NuocCuTru
        {
            get
            {
                return _nuocCuTru;
            }
            set
            {
    			string oldValue =  _nuocCuTru;
    			bool stopChanging = false;
                On_NuocCuTru_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NuocCuTru");
    			if(!stopChanging)
    			{
    				_nuocCuTru = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NuocCuTru");
    				On_NuocCuTru_Changed(oldValue, _nuocCuTru);//\\
    			}
            }
        }
    	public static String NuocCuTru_PropertyName { get { return "NuocCuTru"; } }
        private string _nuocCuTru;
        partial void On_NuocCuTru_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NuocCuTru_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QuocTich
        {
            get
            {
                return _quocTich;
            }
            set
            {
    			string oldValue =  _quocTich;
    			bool stopChanging = false;
                On_QuocTich_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuocTich");
    			if(!stopChanging)
    			{
    				_quocTich = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QuocTich");
    				On_QuocTich_Changed(oldValue, _quocTich);//\\
    			}
            }
        }
    	public static String QuocTich_PropertyName { get { return "QuocTich"; } }
        private string _quocTich;
        partial void On_QuocTich_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QuocTich_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiCuTru
        {
            get
            {
                return _noiCuTru;
            }
            set
            {
    			string oldValue =  _noiCuTru;
    			bool stopChanging = false;
                On_NoiCuTru_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiCuTru");
    			if(!stopChanging)
    			{
    				_noiCuTru = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiCuTru");
    				On_NoiCuTru_Changed(oldValue, _noiCuTru);//\\
    			}
            }
        }
    	public static String NoiCuTru_PropertyName { get { return "NoiCuTru"; } }
        private string _noiCuTru;
        partial void On_NoiCuTru_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiCuTru_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgheNghiep
        {
            get
            {
                return _ngheNghiep;
            }
            set
            {
    			string oldValue =  _ngheNghiep;
    			bool stopChanging = false;
                On_NgheNghiep_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgheNghiep");
    			if(!stopChanging)
    			{
    				_ngheNghiep = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgheNghiep");
    				On_NgheNghiep_Changed(oldValue, _ngheNghiep);//\\
    			}
            }
        }
    	public static String NgheNghiep_PropertyName { get { return "NgheNghiep"; } }
        private string _ngheNghiep;
        partial void On_NgheNghiep_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgheNghiep_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiLamViec
        {
            get
            {
                return _noiLamViec;
            }
            set
            {
    			string oldValue =  _noiLamViec;
    			bool stopChanging = false;
                On_NoiLamViec_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiLamViec");
    			if(!stopChanging)
    			{
    				_noiLamViec = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiLamViec");
    				On_NoiLamViec_Changed(oldValue, _noiLamViec);//\\
    			}
            }
        }
    	public static String NoiLamViec_PropertyName { get { return "NoiLamViec"; } }
        private string _noiLamViec;
        partial void On_NoiLamViec_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiLamViec_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QueQuan
        {
            get
            {
                return _queQuan;
            }
            set
            {
    			string oldValue =  _queQuan;
    			bool stopChanging = false;
                On_QueQuan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QueQuan");
    			if(!stopChanging)
    			{
    				_queQuan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QueQuan");
    				On_QueQuan_Changed(oldValue, _queQuan);//\\
    			}
            }
        }
    	public static String QueQuan_PropertyName { get { return "QueQuan"; } }
        private string _queQuan;
        partial void On_QueQuan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QueQuan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string TinhTrang
        {
            get
            {
                return _tinhTrang;
            }
            set
            {
    			string oldValue =  _tinhTrang;
    			bool stopChanging = false;
                On_TinhTrang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TinhTrang");
    			if(!stopChanging)
    			{
    				_tinhTrang = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("TinhTrang");
    				On_TinhTrang_Changed(oldValue, _tinhTrang);//\\
    			}
            }
        }
    	public static String TinhTrang_PropertyName { get { return "TinhTrang"; } }
        private string _tinhTrang;
        partial void On_TinhTrang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TinhTrang_Changed(string oldValue, string currentValue);

    #endregion

    }
}
