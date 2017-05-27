using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Entity;
using Controller.DTO;
using AutoMapper;

namespace Controller
{
    public class NhanVienController
    {
        private QLNS connect = null;
        public NhanVienController()
        {
            connect = new QLNS();
        }
        public List<TblTTNVCoBan> getAllNhanVien()
        {
           
            List<TblTTNVCoBan> result = new List<TblTTNVCoBan>();
            result = connect.TblTTNVCoBans.ToList();
            return result;
        }
        public Result<TblTTNVCoBan> addNhanVien(TblTTNVCoBan instance)
        {
            var result = new Result<TblTTNVCoBan>();
            var temp = connect.TblTTNVCoBans.Where(x => x.MaNV == instance.MaNV).FirstOrDefault();
            if(temp!=null)
            {
                try
                {
                    connect.TblTTNVCoBans.Add(instance);
                    connect.SaveChanges();
                    result.Success = true;
                    result.Message = "Thành công!";
                    result.Data = instance;
                }
                catch (Exception e)
                {
                    result.Success = false;
                    result.Message = "Đã xảy ra lỗi khi thêm bản ghi! ";
                    result.Data = instance;
                }
                return result;
            }
            else
            {
                result.Success = false;
                result.Message = "Đã tồn tại bản ghi";
                result.Data = instance;
                return result;
            }
        }
        public Result<TblTTNVCoBan> updateNhanVien(TblTTNVCoBan instance)
        {
            var a = AutoMapper.Mapper.Map<TblTTNVCoBan, NhanVienDTO>(instance);
            var result = new Result<TblTTNVCoBan>();
            var temp = connect.TblTTNVCoBans.Where(x => x.MaNV == instance.MaNV).FirstOrDefault();
            if (temp == null)
            {
                try
                {
                    temp = instance;
                    connect.SaveChanges();
                    result.Success = true;
                    result.Message = "Thành công!";
                    result.Data = instance;
                }
                catch (Exception e)
                {
                    result.Success = false;
                    result.Message = "Đã xảy ra lỗi khi thêm bản ghi! ";
                    result.Data = instance;
                }
                return result;
            }
            else
            {
                result.Success = false;
                result.Message = "Không tìm thấy bản ghi";
                return result;
            }
        }
        public Result<TblTTNVCoBan> deleteNhanVien(string manv)
        {
            var result = new Result<TblTTNVCoBan>();
            var temp = connect.TblTTNVCoBans.Where(x => x.MaNV == manv).FirstOrDefault();
            if (temp != null)
            {
                try
                {
                    connect.TblTTNVCoBans.Remove(temp);
                    connect.SaveChanges();
                    result.Success = true;
                    result.Data = temp;
                    result.Message = "Thành công!";
                }
                catch (Exception e)
                {
                    result.Data = temp;
                    result.Success = false;
                    result.Message = "Đã xảy ra lỗi khi thêm bản ghi! ";
                }
                return result;
            }
            else
            {
                result.Success = false;
                result.Message = "Không tìm thấy bản ghi";
                return result;
            }
        }
    }
}
