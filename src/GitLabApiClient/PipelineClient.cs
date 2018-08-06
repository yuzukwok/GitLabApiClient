using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models.Pipeline.Requests;
using GitLabApiClient.Models.Pipeline.Responses;

namespace GitLabApiClient
{
    public sealed class PipelineClient
    {
        private readonly GitLabHttpFacade _httpFacade;

        internal PipelineClient(GitLabHttpFacade httpFacade)
        {
            _httpFacade = httpFacade;
        }
        
        
        
        public async Task<Pipeline> CreateAsync(CreatePipelineRequest request)
        {
            Guard.NotNull(request, nameof(request));
            return await _httpFacade.Post<Pipeline>($"projects/{request.Id}/pipeline", request);
        }


        public async Task<Pipeline> GetAsync(int projectId, int pipelineId)
        {
            return await _httpFacade.Get<Pipeline>($"projects/{projectId}/pipelines/{pipelineId}");
        }


    }
}