//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 04:17:16 ngay 30/08/2016
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_ChiTietThueTNCN_HRM3_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_ChiTietThueTNCN_HRM3_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web1_ChiTietThueTNCN_HRM3_Result object.
        /// </summary>
        /// <param name="tongThuNhapChiuThue">Initial value of the TongThuNhapChiuThue property.</param>
        /// <param name="giamTruGiaCanh">Initial value of the GiamTruGiaCanh property.</param>
        /// <param name="giamTruBanThan">Initial value of the GiamTruBanThan property.</param>
        /// <param name="giamTruNguoiPhuThuoc">Initial value of the GiamTruNguoiPhuThuoc property.</param>
        /// <param name="thuNhapTinhThue">Initial value of the ThuNhapTinhThue property.</param>
        /// <param name="thueTNCNPhaiNop">Initial value of the ThueTNCNPhaiNop property.</param>
        public static spd_Web1_ChiTietThueTNCN_HRM3_Result Createspd_Web1_ChiTietThueTNCN_HRM3_Result(decimal tongThuNhapChiuThue, decimal giamTruGiaCanh, decimal giamTruBanThan, decimal giamTruNguoiPhuThuoc, decimal thuNhapTinhThue, decimal thueTNCNPhaiNop)
        {
            spd_Web1_ChiTietThueTNCN_HRM3_Result spd_Web1_ChiTietThueTNCN_HRM3_Result = new spd_Web1_ChiTietThueTNCN_HRM3_Result();
            spd_Web1_ChiTietThueTNCN_HRM3_Result.TongThuNhapChiuThue = tongThuNhapChiuThue;
            spd_Web1_ChiTietThueTNCN_HRM3_Result.GiamTruGiaCanh = giamTruGiaCanh;
            spd_Web1_ChiTietThueTNCN_HRM3_Result.GiamTruBanThan = giamTruBanThan;
            spd_Web1_ChiTietThueTNCN_HRM3_Result.GiamTruNguoiPhuThuoc = giamTruNguoiPhuThuoc;
            spd_Web1_ChiTietThueTNCN_HRM3_Result.ThuNhapTinhThue = thuNhapTinhThue;
            spd_Web1_ChiTietThueTNCN_HRM3_Result.ThueTNCNPhaiNop = thueTNCNPhaiNop;
            return spd_Web1_ChiTietThueTNCN_HRM3_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal TongThuNhapChiuThue
        {
            get
            {
                return _tongThuNhapChiuThue;
            }
            set
            {
    			decimal oldValue =  _tongThuNhapChiuThue;
    			bool stopChanging = false;
                On_TongThuNhapChiuThue_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongThuNhapChiuThue");
    			if(!stopChanging)
    			{
    				_tongThuNhapChiuThue = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongThuNhapChiuThue");
    				On_TongThuNhapChiuThue_Changed(oldValue, _tongThuNhapChiuThue);//\\
    			}
            }
        }
    	public static String TongThuNhapChiuThue_PropertyName { get { return "TongThuNhapChiuThue"; } }
        private decimal _tongThuNhapChiuThue;
        partial void On_TongThuNhapChiuThue_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_TongThuNhapChiuThue_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal GiamTruGiaCanh
        {
            get
            {
                return _giamTruGiaCanh;
            }
            set
            {
    			decimal oldValue =  _giamTruGiaCanh;
    			bool stopChanging = false;
                On_GiamTruGiaCanh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GiamTruGiaCanh");
    			if(!stopChanging)
    			{
    				_giamTruGiaCanh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("GiamTruGiaCanh");
    				On_GiamTruGiaCanh_Changed(oldValue, _giamTruGiaCanh);//\\
    			}
            }
        }
    	public static String GiamTruGiaCanh_PropertyName { get { return "GiamTruGiaCanh"; } }
        private decimal _giamTruGiaCanh;
        partial void On_GiamTruGiaCanh_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_GiamTruGiaCanh_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal GiamTruBanThan
        {
            get
            {
                return _giamTruBanThan;
            }
            set
            {
    			decimal oldValue =  _giamTruBanThan;
    			bool stopChanging = false;
                On_GiamTruBanThan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GiamTruBanThan");
    			if(!stopChanging)
    			{
    				_giamTruBanThan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("GiamTruBanThan");
    				On_GiamTruBanThan_Changed(oldValue, _giamTruBanThan);//\\
    			}
            }
        }
    	public static String GiamTruBanThan_PropertyName { get { return "GiamTruBanThan"; } }
        private decimal _giamTruBanThan;
        partial void On_GiamTruBanThan_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_GiamTruBanThan_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal GiamTruNguoiPhuThuoc
        {
            get
            {
                return _giamTruNguoiPhuThuoc;
            }
            set
            {
    			decimal oldValue =  _giamTruNguoiPhuThuoc;
    			bool stopChanging = false;
                On_GiamTruNguoiPhuThuoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GiamTruNguoiPhuThuoc");
    			if(!stopChanging)
    			{
    				_giamTruNguoiPhuThuoc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("GiamTruNguoiPhuThuoc");
    				On_GiamTruNguoiPhuThuoc_Changed(oldValue, _giamTruNguoiPhuThuoc);//\\
    			}
            }
        }
    	public static String GiamTruNguoiPhuThuoc_PropertyName { get { return "GiamTruNguoiPhuThuoc"; } }
        private decimal _giamTruNguoiPhuThuoc;
        partial void On_GiamTruNguoiPhuThuoc_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_GiamTruNguoiPhuThuoc_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal ThuNhapTinhThue
        {
            get
            {
                return _thuNhapTinhThue;
            }
            set
            {
    			decimal oldValue =  _thuNhapTinhThue;
    			bool stopChanging = false;
                On_ThuNhapTinhThue_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThuNhapTinhThue");
    			if(!stopChanging)
    			{
    				_thuNhapTinhThue = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThuNhapTinhThue");
    				On_ThuNhapTinhThue_Changed(oldValue, _thuNhapTinhThue);//\\
    			}
            }
        }
    	public static String ThuNhapTinhThue_PropertyName { get { return "ThuNhapTinhThue"; } }
        private decimal _thuNhapTinhThue;
        partial void On_ThuNhapTinhThue_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_ThuNhapTinhThue_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal ThueTNCNPhaiNop
        {
            get
            {
                return _thueTNCNPhaiNop;
            }
            set
            {
    			decimal oldValue =  _thueTNCNPhaiNop;
    			bool stopChanging = false;
                On_ThueTNCNPhaiNop_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThueTNCNPhaiNop");
    			if(!stopChanging)
    			{
    				_thueTNCNPhaiNop = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThueTNCNPhaiNop");
    				On_ThueTNCNPhaiNop_Changed(oldValue, _thueTNCNPhaiNop);//\\
    			}
            }
        }
    	public static String ThueTNCNPhaiNop_PropertyName { get { return "ThueTNCNPhaiNop"; } }
        private decimal _thueTNCNPhaiNop;
        partial void On_ThueTNCNPhaiNop_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_ThueTNCNPhaiNop_Changed(decimal oldValue, decimal currentValue);

    #endregion

    }
}
