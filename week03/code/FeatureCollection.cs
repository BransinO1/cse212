using System.Collections.Generic;

public class Properties
{
    public double Mag { get; set; }
    public string Place { get; set; }
}

public class Geometry
{
    public string Type { get; set; }
    public List<double> Coordinates { get; set; }
}

public class Feature
{
    public string Type { get; set; }
    public Properties Properties { get; set; }
    public Geometry Geometry { get; set; }
    public string Id { get; set; }
}

public class FeatureCollection
{
    public string Type { get; set; }
    public List<Feature> Features { get; set; }
}