using WebApp.Models;

namespace WebApp.Services.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int Id);
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> DeleteCouponAsync(int id);
        Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto);
        Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto);
    }
}
