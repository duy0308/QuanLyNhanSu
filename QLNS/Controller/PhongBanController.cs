using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Entity;
using Controller.DTO;
using AutoMapper;
using System.Data.Entity;

namespace Controller
{
    public class PhongBanController
    {
        private QLNS connect = null;
        public PhongBanController()
        {
            connect = new QLNS();
        }
        public List<TblPhongBan> getAllPhongBan()
        {
            List<TblPhongBan> result = new List<TblPhongBan>();
            result = connect.TblPhongBans.ToList();
            return result;
        }
        public TblPhongBan getOnePhongBan(string maPB)
        {
            TblPhongBan result = new TblPhongBan();
            result = connect.TblPhongBans.Where(x=> x.MaPhong == maPB).FirstOrDefault();
            return result;
        }

        public Result<TblPhongBan> addPhongBan(TblPhongBan instance)
        {
            var result = new Result<TblPhongBan>();
            var temp = connect.TblPhongBans.Where(x => x.MaPhong == instance.MaPhong).FirstOrDefault();
            if(temp==null)
            {
                try
                {
                    connect.TblPhongBans.Add(instance);
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
        public Result<TblPhongBan> updatePhongBan(TblPhongBan instance)
        {
            //var a = AutoMapper.Mapper.Map<TblTTNVCoBan, NhanVienDTO>(instance);
            var result = new Result<TblPhongBan>();
            var temp = connect.TblPhongBans.Where(x => x.MaPhong == instance.MaPhong).FirstOrDefault();
            if (temp != null)
            {
                try
                {
                    temp = instance;
                    connect.TblPhongBans.Attach(temp);
                    connect.Entry(temp).State = EntityState.Modified;
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
        public Result<TblPhongBan> deletePhongBan(string ma)
        {
            var result = new Result<TblPhongBan>();
            var temp = connect.TblPhongBans.Where(x => x.MaPhong == ma).FirstOrDefault();
            var size = connect.TblTTNVCoBans.Where(x => x.MaPhong == ma).Count();
            if (temp != null)
            {
                if (size == 0)
                {
                    try
                    {
                        connect.TblPhongBans.Remove(temp);
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
                }
                else
                {
                    result.Data = temp;
                    result.Success = false;
                    result.Message = "Tòn tại "+size+" nhân viên thuộc phòng này!";
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
