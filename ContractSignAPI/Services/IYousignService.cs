using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ContractSignAPI.Services.YouSign;

namespace ContractSignAPI.Services
{
    public interface IYousignService
    {
        Task<FileOutput> FilePost(FileInput file);

        Task<FileOutput> FileGet(string id);

        Task<string> FileDownload(string id);

        Task<ProcedureOutput> ProcedurePost(ProcedureInput input);

        Task Delete(string id);

        Task<StampOutput> Server_StampsPost(StampInput cachet);

        Task<List<SignatureUIOutput>> SignaturesUIGet();

        Task<SignatureUIInput> SignaturesUIPost(SignatureUIInput input);

    }
}
