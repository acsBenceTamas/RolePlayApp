namespace RolePlayApp.Backend.Models
{
    public enum MessageItemType
    {
        /// <summary>
        /// A <see cref="Character"/>'s action.
        /// </summary>
        Action,
        /// <summary>
        /// A <see cref="Character"/>'s speech.
        /// </summary>
        Speech,
        /// <summary>
        /// An environmental event that does not belong to a specific
        /// <see cref="Character"/> or belongs to several.
        /// </summary>
        Environment
    }
}
