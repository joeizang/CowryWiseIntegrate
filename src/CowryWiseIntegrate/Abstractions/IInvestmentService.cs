using CowryWiseIntegrate.DTOs.Investment;
using CowryWiseIntegrate.DTOs.Wallet;
using System.Threading.Tasks;

namespace CowryWiseIntegrate.Abstractions
{
    public interface IInvestmentService
    {
        Task<SingleInvestmentResponseDto> CreateInvestment(CreateInvestmentInputModel inputModel);

        Task<InvestmentPaginatedDtoResponse> GetAllInvestments(InvestmentPaginatedResponseInput inputModel);

        Task<TransferFromWalletResponseDto> FundInvestment(WalletTransferInputModel inputModel);

        Task<InvestmentLiquidatedDto> LiquidateInvestment(string units, string investmentId, string accountId, string customerId);

        Task<SingleInvestmentResponseDto> GetSingleInvestment(string investmentId);

    }
}
