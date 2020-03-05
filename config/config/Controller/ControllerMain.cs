namespace config.Controller
{
    /// <summary>
    /// Main app controller.
    /// </summary>
    public class ControllerMain
    {
        /// <summary>
        /// Confirm if receive data.
        /// </summary>
        /// <param name="region">Region</param>
        /// <param name="username">Username</param>
        /// <returns>True: createad | False: error.</returns>
        public bool ConfirmReceiveData(string region, string username)
        {
            return !string.IsNullOrEmpty(region) && !string.IsNullOrEmpty(username);
        }
    }
}
