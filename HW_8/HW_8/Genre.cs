using System.Xml.Serialization;

namespace HW_8
{
    public enum Genre
    {
        [XmlEnum(Name = "Computer")]
        Computer,

        [XmlEnum(Name = "Science Fiction")]
        ScienceFiction,

        [XmlEnum(Name = "Horror")]
        Horror,

        [XmlEnum(Name = "Romance")]
        Romance,

        [XmlEnum(Name = "Fantasy")]
        Fantasy
    }
}
