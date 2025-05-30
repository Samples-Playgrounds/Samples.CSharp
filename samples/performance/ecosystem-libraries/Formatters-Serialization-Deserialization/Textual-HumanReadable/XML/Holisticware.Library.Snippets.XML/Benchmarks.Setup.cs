

namespace Holisticware.Library.Snippets.XML;

using System.Linq;
using System.Collections.Generic;

public partial class
                                       Benchmarks_XML
{
    public static
        Models.Weather
                                        weather = new ()
                                                    {
                                                        MinTemp = 10,
                                                        MaxTemp = 20,
                                                        Rainfall = 5,
                                                        Evaporation = 3,
                                                        Sunshine = 8,
                                                        WindGustDir = "N",
                                                        WindGustSpeed = 30,
                                                        WindDir9am = "NE",
                                                        WindDir3pm = "SE",
                                                        WindSpeed9am = 15,
                                                        WindSpeed3pm = 20,
                                                        Humidity9am = 60,
                                                        Humidity3pm = 50,
                                                        Pressure9am = 1010,
                                                        Pressure3pm = 1005,
                                                        Cloud9am = 2,
                                                        Cloud3pm = 1
                                                    };

    public static
        Models.Iris
                                        iris = new ()
                                                    {
                                                        SepalLength = 5.1,
                                                        SepalWidth = 3.5,
                                                        PetalLength = 1.4,
                                                        PetalWidth = 0.2,
                                                        Variety = "Setosa"

                                                    };
}
