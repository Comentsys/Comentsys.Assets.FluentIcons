namespace Comentsys.Assets.FluentIcons;

/// <summary>
/// Fluent Icon Data
/// Fluent UI Icons designed by Microsoft - a collection of familiar, friendly and modern icons. License: MIT License
/// </summary>
public class FluentIconData
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="type">Fluent Icon Type</param>
    /// <param name="name">Name</param>
    /// <param name="keywords">Keywords</param>
    /// <param name="direction">Icon Direction</param>
    /// <param name="defaultDirection">Default Icon Direction</param>
    public FluentIconData(FluentIconType type, string? name, string[]? keywords, string? direction = null, string? defaultDirection = null) =>
        (Type, Name, Keywords, Direction, DefaultDirection) =
        (type, name, keywords, direction, defaultDirection);

    /// <summary>
    /// Fluent Icon Type
    /// </summary>
    public FluentIconType Type { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Keywords
    /// </summary>
    public string[]? Keywords { get; set; }

    /// <summary>
    /// Icon Direction
    /// </summary>
    public string? Direction { get; set; }

    /// <summary>
    /// Default Icon Direction
    /// </summary>
    public string? DefaultDirection { get; set; }

    /// <summary>
    /// Is Icon Directional?
    /// </summary>
    public bool IsDirectional => 
        Direction is not null;
}
