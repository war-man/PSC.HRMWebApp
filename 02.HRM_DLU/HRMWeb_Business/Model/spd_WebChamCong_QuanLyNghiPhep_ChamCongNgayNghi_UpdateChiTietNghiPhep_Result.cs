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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static spd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result Createspd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result(System.Guid oid)
        {
            spd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result spd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result = new spd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result();
            spd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result.Oid = oid;
            return spd_WebChamCong_QuanLyNghiPhep_ChamCongNgayNghi_UpdateChiTietNghiPhep_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid Oid
        {
            get
            {
                return _oid;
            }
            set
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
    	public static String Oid_PropertyName { get { return "Oid"; } }
        private System.Guid _oid;
        partial void On_Oid_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_Oid_Changed(System.Guid oldValue, System.Guid currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> QuanLyNghiPhep
        {
            get
            {
                return _quanLyNghiPhep;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _quanLyNghiPhep;
    			bool stopChanging = false;
                On_QuanLyNghiPhep_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanLyNghiPhep");
    			if(!stopChanging)
    			{
    				_quanLyNghiPhep = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("QuanLyNghiPhep");
    				On_QuanLyNghiPhep_Changed(oldValue, _quanLyNghiPhep);//\\
    			}
            }
        }
    	public static String QuanLyNghiPhep_PropertyName { get { return "QuanLyNghiPhep"; } }
        private Nullable<System.Guid> _quanLyNghiPhep;
        partial void On_QuanLyNghiPhep_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_QuanLyNghiPhep_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> BoPhan
        {
            get
            {
                return _boPhan;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _boPhan;
    			bool stopChanging = false;
                On_BoPhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BoPhan");
    			if(!stopChanging)
    			{
    				_boPhan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("BoPhan");
    				On_BoPhan_Changed(oldValue, _boPhan);//\\
    			}
            }
        }
    	public static String BoPhan_PropertyName { get { return "BoPhan"; } }
        private Nullable<System.Guid> _boPhan;
        partial void On_BoPhan_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_BoPhan_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> ThongTinNhanVien
        {
            get
            {
                return _thongTinNhanVien;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _thongTinNhanVien;
    			bool stopChanging = false;
                On_ThongTinNhanVien_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThongTinNhanVien");
    			if(!stopChanging)
    			{
    				_thongTinNhanVien = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThongTinNhanVien");
    				On_ThongTinNhanVien_Changed(oldValue, _thongTinNhanVien);//\\
    			}
            }
        }
    	public static String ThongTinNhanVien_PropertyName { get { return "ThongTinNhanVien"; } }
        private Nullable<System.Guid> _thongTinNhanVien;
        partial void On_ThongTinNhanVien_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_ThongTinNhanVien_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongSoNgayPhep
        {
            get
            {
                return _tongSoNgayPhep;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongSoNgayPhep;
    			bool stopChanging = false;
                On_TongSoNgayPhep_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongSoNgayPhep");
    			if(!stopChanging)
    			{
    				_tongSoNgayPhep = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongSoNgayPhep");
    				On_TongSoNgayPhep_Changed(oldValue, _tongSoNgayPhep);//\\
    			}
            }
        }
    	public static String TongSoNgayPhep_PropertyName { get { return "TongSoNgayPhep"; } }
        private Nullable<decimal> _tongSoNgayPhep;
        partial void On_TongSoNgayPhep_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongSoNgayPhep_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayPhepDaNghi
        {
            get
            {
                return _soNgayPhepDaNghi;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayPhepDaNghi;
    			bool stopChanging = false;
                On_SoNgayPhepDaNghi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayPhepDaNghi");
    			if(!stopChanging)
    			{
    				_soNgayPhepDaNghi = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayPhepDaNghi");
    				On_SoNgayPhepDaNghi_Changed(oldValue, _soNgayPhepDaNghi);//\\
    			}
            }
        }
    	public static String SoNgayPhepDaNghi_PropertyName { get { return "SoNgayPhepDaNghi"; } }
        private Nullable<decimal> _soNgayPhepDaNghi;
        partial void On_SoNgayPhepDaNghi_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayPhepDaNghi_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayPhepConLai
        {
            get
            {
                return _soNgayPhepConLai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayPhepConLai;
    			bool stopChanging = false;
                On_SoNgayPhepConLai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayPhepConLai");
    			if(!stopChanging)
    			{
    				_soNgayPhepConLai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayPhepConLai");
    				On_SoNgayPhepConLai_Changed(oldValue, _soNgayPhepConLai);//\\
    			}
            }
        }
    	public static String SoNgayPhepConLai_PropertyName { get { return "SoNgayPhepConLai"; } }
        private Nullable<decimal> _soNgayPhepConLai;
        partial void On_SoNgayPhepConLai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayPhepConLai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayPhepCongThem
        {
            get
            {
                return _soNgayPhepCongThem;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayPhepCongThem;
    			bool stopChanging = false;
                On_SoNgayPhepCongThem_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayPhepCongThem");
    			if(!stopChanging)
    			{
    				_soNgayPhepCongThem = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayPhepCongThem");
    				On_SoNgayPhepCongThem_Changed(oldValue, _soNgayPhepCongThem);//\\
    			}
            }
        }
    	public static String SoNgayPhepCongThem_PropertyName { get { return "SoNgayPhepCongThem"; } }
        private Nullable<decimal> _soNgayPhepCongThem;
        partial void On_SoNgayPhepCongThem_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayPhepCongThem_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayPhepNam
        {
            get
            {
                return _soNgayPhepNam;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayPhepNam;
    			bool stopChanging = false;
                On_SoNgayPhepNam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayPhepNam");
    			if(!stopChanging)
    			{
    				_soNgayPhepNam = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayPhepNam");
    				On_SoNgayPhepNam_Changed(oldValue, _soNgayPhepNam);//\\
    			}
            }
        }
    	public static String SoNgayPhepNam_PropertyName { get { return "SoNgayPhepNam"; } }
        private Nullable<decimal> _soNgayPhepNam;
        partial void On_SoNgayPhepNam_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayPhepNam_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayPhepNamTruoc
        {
            get
            {
                return _soNgayPhepNamTruoc;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayPhepNamTruoc;
    			bool stopChanging = false;
                On_SoNgayPhepNamTruoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayPhepNamTruoc");
    			if(!stopChanging)
    			{
    				_soNgayPhepNamTruoc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayPhepNamTruoc");
    				On_SoNgayPhepNamTruoc_Changed(oldValue, _soNgayPhepNamTruoc);//\\
    			}
            }
        }
    	public static String SoNgayPhepNamTruoc_PropertyName { get { return "SoNgayPhepNamTruoc"; } }
        private Nullable<decimal> _soNgayPhepNamTruoc;
        partial void On_SoNgayPhepNamTruoc_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayPhepNamTruoc_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}