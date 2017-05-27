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
    public class BoPhanController
    {
        private QLNS connect = null;
        public BoPhanController()
        {
            connect = new QLNS();
        }
        public List<TblBoPhan> getAllBoPhan()
        {
            

            List<TblBoPhan> result = new List<TblBoPhan>();
            result = connect.TblBoPhans.ToList();
            return result;
        }
        public Result<TblBoPhan> addBoPhan(TblBoPhan instance)
        {
            var result = new Result<TblBoPhan>();
            var temp = connect.TblBoPhans.Where(x => x.MaBophan == instance.MaBophan).FirstOrDefault();
            if(temp==null)
            {
                try
                {
                    connect.TblBoPhans.Add(instance);
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
        public Result<TblBoPhan> updateBoPhan(TblBoPhan instance)
        {
            //var a = AutoMapper.Mapper.Map<TblTTNVCoBan, NhanVienDTO>(instance);
            var result = new Result<TblBoPhan>();
            var temp = connect.TblBoPhans.Where(x => x.MaBophan == instance.MaBophan).FirstOrDefault();
            if (temp != null)
            {
                try
                {
                    temp = instance;
                    connect.TblBoPhans.Attach(temp);
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
        public Result<TblBoPhan> deleteBoPhan(string ma)
        {
            var result = new Result<TblBoPhan>();
            var temp = connect.TblBoPhans.Where(x => x.MaBophan == ma).FirstOrDefault();
            int size = connect.TblPhongBans.Where(x => x.MaBoPhan == ma).Count();
            if (temp != null)
            {
                if(size == 0)
                {
                    try
                    {
                        connect.TblBoPhans.Remove(temp);
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
                    result.Data = temp;
                    result.Success = false;
                    result.Message = "Có phòng ban thuộc bộ phận này ! ";
                    return result;
                }

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
