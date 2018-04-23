
namespace HelseId.Constants.Parameters
{
    public static class InternalParameters
    {

        /// <summary>
        /// This parameter is used between HelseID and ID-porten to allow ID-porten to identify the HelseID client
        /// </summary>
        public const string OnBehalfOf = "onbehalfof";

        /// <summary>
        /// Prompt parameter which should be forwarded to IDP
        /// The prompt parameter itself is removed by the IdSrv4 authorize endpoint logic 
        /// in AuthorizeInteractionResponseGenerator.ProcessLoginAsync().
        /// </summary>
        public const string ForwardedPrompt = "forwarded_prompt";
    }
}
