//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 12:14:05 ngay 06/04/2019
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_ChiTietNghiPhep")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_ChiTietNghiPhep : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_ChiTietNghiPhep()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_ChiTietNghiPhep()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_ChiTietNghiPhep object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_ChiTietNghiPhep CreateCC_ChiTietNghiPhep(System.Guid oid)
        {
            CC_ChiTietNghiPhep cC_ChiTietNghiPhep = new CC_ChiTietNghiPhep();
            cC_ChiTietNghiPhep.Oid = oid;
            return cC_ChiTietNghiPhep;
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
        public Nullable<decimal> SoNgayPhepNamHienTai
        {
            get
            {
                return _soNgayPhepNamHienTai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayPhepNamHienTai;
    			bool stopChanging = false;
                On_SoNgayPhepNamHienTai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayPhepNamHienTai");
    			if(!stopChanging)
    			{
    				_soNgayPhepNamHienTai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayPhepNamHienTai");
    				On_SoNgayPhepNamHienTai_Changed(oldValue, _soNgayPhepNamHienTai);//\\
    			}
            }
        }
    	public static String SoNgayPhepNamHienTai_PropertyName { get { return "SoNgayPhepNamHienTai"; } }
        private Nullable<decimal> _soNgayPhepNamHienTai;
        partial void On_SoNgayPhepNamHienTai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayPhepNamHienTai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayTamUngNamTruoc
        {
            get
            {
                return _soNgayTamUngNamTruoc;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayTamUngNamTruoc;
    			bool stopChanging = false;
                On_SoNgayTamUngNamTruoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayTamUngNamTruoc");
    			if(!stopChanging)
    			{
    				_soNgayTamUngNamTruoc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayTamUngNamTruoc");
    				On_SoNgayTamUngNamTruoc_Changed(oldValue, _soNgayTamUngNamTruoc);//\\
    			}
            }
        }
    	public static String SoNgayTamUngNamTruoc_PropertyName { get { return "SoNgayTamUngNamTruoc"; } }
        private Nullable<decimal> _soNgayTamUngNamTruoc;
        partial void On_SoNgayTamUngNamTruoc_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayTamUngNamTruoc_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayTamUngHienTai
        {
            get
            {
                return _soNgayTamUngHienTai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayTamUngHienTai;
    			bool stopChanging = false;
                On_SoNgayTamUngHienTai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayTamUngHienTai");
    			if(!stopChanging)
    			{
    				_soNgayTamUngHienTai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayTamUngHienTai");
    				On_SoNgayTamUngHienTai_Changed(oldValue, _soNgayTamUngHienTai);//\\
    			}
            }
        }
    	public static String SoNgayTamUngHienTai_PropertyName { get { return "SoNgayTamUngHienTai"; } }
        private Nullable<decimal> _soNgayTamUngHienTai;
        partial void On_SoNgayTamUngHienTai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayTamUngHienTai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayPhepDaNghi_QuiI
        {
            get
            {
                return _soNgayPhepDaNghi_QuiI;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayPhepDaNghi_QuiI;
    			bool stopChanging = false;
                On_SoNgayPhepDaNghi_QuiI_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayPhepDaNghi_QuiI");
    			if(!stopChanging)
    			{
    				_soNgayPhepDaNghi_QuiI = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayPhepDaNghi_QuiI");
    				On_SoNgayPhepDaNghi_QuiI_Changed(oldValue, _soNgayPhepDaNghi_QuiI);//\\
    			}
            }
        }
    	public static String SoNgayPhepDaNghi_QuiI_PropertyName { get { return "SoNgayPhepDaNghi_QuiI"; } }
        private Nullable<decimal> _soNgayPhepDaNghi_QuiI;
        partial void On_SoNgayPhepDaNghi_QuiI_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayPhepDaNghi_QuiI_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayPhepNamTruoc_BK
        {
            get
            {
                return _soNgayPhepNamTruoc_BK;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayPhepNamTruoc_BK;
    			bool stopChanging = false;
                On_SoNgayPhepNamTruoc_BK_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayPhepNamTruoc_BK");
    			if(!stopChanging)
    			{
    				_soNgayPhepNamTruoc_BK = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayPhepNamTruoc_BK");
    				On_SoNgayPhepNamTruoc_BK_Changed(oldValue, _soNgayPhepNamTruoc_BK);//\\
    			}
            }
        }
    	public static String SoNgayPhepNamTruoc_BK_PropertyName { get { return "SoNgayPhepNamTruoc_BK"; } }
        private Nullable<decimal> _soNgayPhepNamTruoc_BK;
        partial void On_SoNgayPhepNamTruoc_BK_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayPhepNamTruoc_BK_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongSoNgayBu
        {
            get
            {
                return _tongSoNgayBu;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongSoNgayBu;
    			bool stopChanging = false;
                On_TongSoNgayBu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongSoNgayBu");
    			if(!stopChanging)
    			{
    				_tongSoNgayBu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongSoNgayBu");
    				On_TongSoNgayBu_Changed(oldValue, _tongSoNgayBu);//\\
    			}
            }
        }
    	public static String TongSoNgayBu_PropertyName { get { return "TongSoNgayBu"; } }
        private Nullable<decimal> _tongSoNgayBu;
        partial void On_TongSoNgayBu_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongSoNgayBu_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayBuDaNghi
        {
            get
            {
                return _soNgayBuDaNghi;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayBuDaNghi;
    			bool stopChanging = false;
                On_SoNgayBuDaNghi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayBuDaNghi");
    			if(!stopChanging)
    			{
    				_soNgayBuDaNghi = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayBuDaNghi");
    				On_SoNgayBuDaNghi_Changed(oldValue, _soNgayBuDaNghi);//\\
    			}
            }
        }
    	public static String SoNgayBuDaNghi_PropertyName { get { return "SoNgayBuDaNghi"; } }
        private Nullable<decimal> _soNgayBuDaNghi;
        partial void On_SoNgayBuDaNghi_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayBuDaNghi_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayBuConLai
        {
            get
            {
                return _soNgayBuConLai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayBuConLai;
    			bool stopChanging = false;
                On_SoNgayBuConLai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayBuConLai");
    			if(!stopChanging)
    			{
    				_soNgayBuConLai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayBuConLai");
    				On_SoNgayBuConLai_Changed(oldValue, _soNgayBuConLai);//\\
    			}
            }
        }
    	public static String SoNgayBuConLai_PropertyName { get { return "SoNgayBuConLai"; } }
        private Nullable<decimal> _soNgayBuConLai;
        partial void On_SoNgayBuConLai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayBuConLai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayBuNamHienTai
        {
            get
            {
                return _soNgayBuNamHienTai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayBuNamHienTai;
    			bool stopChanging = false;
                On_SoNgayBuNamHienTai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayBuNamHienTai");
    			if(!stopChanging)
    			{
    				_soNgayBuNamHienTai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayBuNamHienTai");
    				On_SoNgayBuNamHienTai_Changed(oldValue, _soNgayBuNamHienTai);//\\
    			}
            }
        }
    	public static String SoNgayBuNamHienTai_PropertyName { get { return "SoNgayBuNamHienTai"; } }
        private Nullable<decimal> _soNgayBuNamHienTai;
        partial void On_SoNgayBuNamHienTai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayBuNamHienTai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayBuNamTruoc
        {
            get
            {
                return _soNgayBuNamTruoc;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayBuNamTruoc;
    			bool stopChanging = false;
                On_SoNgayBuNamTruoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayBuNamTruoc");
    			if(!stopChanging)
    			{
    				_soNgayBuNamTruoc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayBuNamTruoc");
    				On_SoNgayBuNamTruoc_Changed(oldValue, _soNgayBuNamTruoc);//\\
    			}
            }
        }
    	public static String SoNgayBuNamTruoc_PropertyName { get { return "SoNgayBuNamTruoc"; } }
        private Nullable<decimal> _soNgayBuNamTruoc;
        partial void On_SoNgayBuNamTruoc_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayBuNamTruoc_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayBuNamTruoc_BK
        {
            get
            {
                return _soNgayBuNamTruoc_BK;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayBuNamTruoc_BK;
    			bool stopChanging = false;
                On_SoNgayBuNamTruoc_BK_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayBuNamTruoc_BK");
    			if(!stopChanging)
    			{
    				_soNgayBuNamTruoc_BK = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayBuNamTruoc_BK");
    				On_SoNgayBuNamTruoc_BK_Changed(oldValue, _soNgayBuNamTruoc_BK);//\\
    			}
            }
        }
    	public static String SoNgayBuNamTruoc_BK_PropertyName { get { return "SoNgayBuNamTruoc_BK"; } }
        private Nullable<decimal> _soNgayBuNamTruoc_BK;
        partial void On_SoNgayBuNamTruoc_BK_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayBuNamTruoc_BK_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChiTietNghiPhep_CC_QuanLyNghiPhep", "CC_QuanLyNghiPhep")]
        public CC_QuanLyNghiPhep CC_QuanLyNghiPhep
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_QuanLyNghiPhep>("ERPModel.FK_CC_ChiTietNghiPhep_CC_QuanLyNghiPhep", "CC_QuanLyNghiPhep").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CC_QuanLyNghiPhep_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_QuanLyNghiPhep>("ERPModel.FK_CC_ChiTietNghiPhep_CC_QuanLyNghiPhep", "CC_QuanLyNghiPhep").Value = value;
    				On_CC_QuanLyNghiPhep_Changed(this.CC_QuanLyNghiPhep);//\\//
    			}
    	    }
        }
    	public static String CC_QuanLyNghiPhep_ReferencePropertyName { get { return "CC_QuanLyNghiPhep"; } }
    	partial void On_CC_QuanLyNghiPhep_Changing(ref CC_QuanLyNghiPhep newValue, ref bool stopChanging);
    	partial void On_CC_QuanLyNghiPhep_Changed(CC_QuanLyNghiPhep currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CC_QuanLyNghiPhep> CC_QuanLyNghiPhepReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_QuanLyNghiPhep>("ERPModel.FK_CC_ChiTietNghiPhep_CC_QuanLyNghiPhep", "CC_QuanLyNghiPhep");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CC_QuanLyNghiPhep>("ERPModel.FK_CC_ChiTietNghiPhep_CC_QuanLyNghiPhep", "CC_QuanLyNghiPhep", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChiTietNghiPhep_ThongTinNhanVien", "ThongTinNhanVien")]
        public ThongTinNhanVien ThongTinNhanVien1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChiTietNghiPhep_ThongTinNhanVien", "ThongTinNhanVien").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_ThongTinNhanVien1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChiTietNghiPhep_ThongTinNhanVien", "ThongTinNhanVien").Value = value;
    				On_ThongTinNhanVien1_Changed(this.ThongTinNhanVien1);//\\//
    			}
    	    }
        }
    	public static String ThongTinNhanVien1_ReferencePropertyName { get { return "ThongTinNhanVien1"; } }
    	partial void On_ThongTinNhanVien1_Changing(ref ThongTinNhanVien newValue, ref bool stopChanging);
    	partial void On_ThongTinNhanVien1_Changed(ThongTinNhanVien currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ThongTinNhanVien> ThongTinNhanVien1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChiTietNghiPhep_ThongTinNhanVien", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChiTietNghiPhep_ThongTinNhanVien", "ThongTinNhanVien", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChiTietNghiPhep_BoPhan", "BoPhan")]
        public BoPhan BoPhan1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_CC_ChiTietNghiPhep_BoPhan", "BoPhan").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_BoPhan1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_CC_ChiTietNghiPhep_BoPhan", "BoPhan").Value = value;
    				On_BoPhan1_Changed(this.BoPhan1);//\\//
    			}
    	    }
        }
    	public static String BoPhan1_ReferencePropertyName { get { return "BoPhan1"; } }
    	partial void On_BoPhan1_Changing(ref BoPhan newValue, ref bool stopChanging);
    	partial void On_BoPhan1_Changed(BoPhan currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BoPhan> BoPhan1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_CC_ChiTietNghiPhep_BoPhan", "BoPhan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BoPhan>("ERPModel.FK_CC_ChiTietNghiPhep_BoPhan", "BoPhan", value);
                }
            }
        }

        #endregion

    }
}
