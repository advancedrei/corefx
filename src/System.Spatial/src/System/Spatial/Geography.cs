// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using System.Spatial.Utilities;

namespace System.Spatial
{


    /// <summary>
    /// Represents data in a geodetic (round earth) coordinate system.
    /// </summary>
    //[DataContract]
    //[Serializable]
    public abstract class Geography
    {

        public Geography()
        {
        }

        /// <summary> Gets the default coordinate system id (SRID) for geography values (WGS 84) </summary>
        /// <returns>The default coordinate system id (SRID) for geography values (WGS 84)</returns>
        public static int DefaultCoordinateSystemId { get; } = 4326; /* WGS 84 */

        /// <summary> Gets or sets a data contract serializable well known representation of this Geography value. </summary>
        /// <returns>A data contract serializable well known representation of this Geography value.</returns>
        //[DataMember(Name = "Geography")]
        public WellKnownValue WellKnownValue { get; set; }

        #region Well Known Binary Static Constructors

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> value based on the specified well known binary value.
        /// </summary>
        /// <returns>
        /// A new Geography value as defined by the well known binary value with the default geography coordinate system identifier (SRID)(
        /// <see
        ///     cref="P:System.Spatial.Geography.DefaultCoordinateSystemId" />
        /// ).
        /// </returns>
        /// <param name="wellKnownBinary">A byte array that contains a well known binary representation of the geography value.</param>
        public virtual Geography FromBinary(byte[] wellKnownBinary)
        {
            Check.NotNull(wellKnownBinary, "wellKnownBinary");
            return null;
        }


        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> value based on the specified well known binary value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known binary value with the specified coordinate system identifier.</returns>
        /// <param name="wellKnownBinary">A byte array that contains a well known binary representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography FromBinary(byte[] wellKnownBinary, int coordinateSystemId)
        {
            Check.NotNull(wellKnownBinary, "wellKnownBinary");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> line value based on the specified well known binary value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known binary value with the specified coordinate system identifier.</returns>
        /// <param name="lineWellKnownBinary">A byte array that contains a well known binary representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography LineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId)
        {
            Check.NotNull(lineWellKnownBinary, "lineWellKnownBinary");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> point value based on the specified well known binary value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known binary value with the specified coordinate system identifier.</returns>
        /// <param name="pointWellKnownBinary">A byte array that contains a well known binary representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography PointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId)
        {
            Check.NotNull(pointWellKnownBinary, "pointWellKnownBinary");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> polygon value based on the specified well known binary value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known binary value with the specified coordinate system identifier.</returns>
        /// <param name="polygonWellKnownBinary">A byte array that contains a well known binary representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography PolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId)
        {
            Check.NotNull(polygonWellKnownBinary, "polygonWellKnownBinary");
            return null;
        }

        /// <summary>Returns the multiline value from a binary value.</summary>
        /// <returns>The multiline value from a binary value.</returns>
        /// <param name="multiLineWellKnownBinary">The well-known binary value.</param>
        /// <param name="coordinateSystemId">The coordinate system identifier.</param>
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "MultiLine",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "multiLine",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "multi",
            Justification = "Match OGC, EDM")]
        public static Geography MultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId)
        {
            Check.NotNull(multiLineWellKnownBinary, "multiLineWellKnownBinary");
            return null;
        }

        /// <summary>Returns the multipoint value from a well-known binary value.</summary>
        /// <returns>The multipoint value from a well-known binary value.</returns>
        /// <param name="multiPointWellKnownBinary">The well-known binary value.</param>
        /// <param name="coordinateSystemId">The coordinate system identifier.</param>
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "MultiPoint",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "multiPoint",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "multi",
            Justification = "Match OGC, EDM")]
        public static Geography MultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId)
        {
            Check.NotNull(multiPointWellKnownBinary, "multiPointWellKnownBinary");
            return null;
        }

        /// <summary>Returns the multi polygon value from a well-known binary value.</summary>
        /// <returns>The multi polygon value from a well-known binary value.</returns>
        /// <param name="multiPolygonWellKnownBinary">The multi polygon well-known binary value.</param>
        /// <param name="coordinateSystemId">The coordinate system identifier.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "multi",
            Justification = "Match OGC, EDM")]
        public static Geography MultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId)
        {
            Check.NotNull(multiPolygonWellKnownBinary, "multiPolygonWellKnownBinary");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> collection value based on the specified well known binary value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known binary value with the specified coordinate system identifier.</returns>
        /// <param name="geographyCollectionWellKnownBinary">A byte array that contains a well known binary representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography GeographyCollectionFromBinary(byte[] geographyCollectionWellKnownBinary, int coordinateSystemId)
        {
            Check.NotNull(geographyCollectionWellKnownBinary, "geographyCollectionWellKnownBinary");
            return null;
        }

        #endregion

        #region GML Static Constructors

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> value based on the specified Geography Markup Language (GML) value.
        /// </summary>
        /// <returns>
        /// A new Geography value as defined by the GML value with the default geography coordinate system identifier (SRID) (
        /// <see
        ///     cref="P:System.Spatial.Geography.DefaultCoordinateSystemId" />
        /// ).
        /// </returns>
        /// <param name="geographyMarkup">A string that contains a Geography Markup Language (GML) representation of the geography value.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Gml")]
        public static Geography FromGml(string geographyMarkup)
        {
            Check.NotNull(geographyMarkup, "geographyMarkup");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> value based on the specified Geography Markup Language (GML) value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the GML value with the specified coordinate system identifier.</returns>
        /// <param name="geographyMarkup">A string that contains a Geography Markup Language (GML) representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Gml")]
        public static Geography FromGml(string geographyMarkup, int coordinateSystemId)
        {
            Check.NotNull(geographyMarkup, "geographyMarkup");
            return null;
        }

        #endregion

        #region Well Known Text Static Constructors

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> value based on the specified well known text value.
        /// </summary>
        /// <returns>
        /// A new Geography value as defined by the well known text value with the default geography coordinate system identifier (SRID) (
        /// <see
        ///     cref="P:System.Spatial.Geography.DefaultCoordinateSystemId" />
        /// ).
        /// </returns>
        /// <param name="wellKnownText">A string that contains a well known text representation of the geography value.</param>
        public static Geography FromText(string wellKnownText)
        {
            Check.NotNull(wellKnownText, "wellKnownText");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> value based on the specified well known text value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known text value with the specified coordinate system identifier.</returns>
        /// <param name="wellKnownText">A string that contains a well known text representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography FromText(string wellKnownText, int coordinateSystemId)
        {
            Check.NotNull(wellKnownText, "wellKnownText");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> line value based on the specified well known text value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known text value with the specified coordinate system identifier.</returns>
        /// <param name="lineWellKnownText">A string that contains a well known text representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography LineFromText(string lineWellKnownText, int coordinateSystemId)
        {
            Check.NotNull(lineWellKnownText, "lineWellKnownText");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> point value based on the specified well known text value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known text value with the specified coordinate system identifier.</returns>
        /// <param name="pointWellKnownText">A string that contains a well known text representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography PointFromText(string pointWellKnownText, int coordinateSystemId)
        {
            Check.NotNull(pointWellKnownText, "pointWellKnownText");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> polygon value based on the specified well known text value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known text value with the specified coordinate system identifier.</returns>
        /// <param name="polygonWellKnownText">A string that contains a well known text representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography PolygonFromText(string polygonWellKnownText, int coordinateSystemId)
        {
            Check.NotNull(polygonWellKnownText, "polygonWellKnownText");
            return null;
        }

        /// <summary>Returns the multiline value from a well-known text value.</summary>
        /// <returns>The multiline value from a well-known text value.</returns>
        /// <param name="multiLineWellKnownText">The well-known text.</param>
        /// <param name="coordinateSystemId">The coordinate system identifier.</param>
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "MultiLine",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "multiLine",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "multi",
            Justification = "Match OGC, EDM")]
        public static Geography MultiLineFromText(string multiLineWellKnownText, int coordinateSystemId)
        {
            Check.NotNull(multiLineWellKnownText, "multiLineWellKnownText");
            return null;
        }

        /// <summary>Returns the multipoint value from a well-known text value.</summary>
        /// <returns>The multipoint value from a well-known text value.</returns>
        /// <param name="multiPointWellKnownText">The well-known text value.</param>
        /// <param name="coordinateSystemId">The coordinate system identifier.</param>
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "MultiPoint",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "multiPoint",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "multi",
            Justification = "Match OGC, EDM")]
        public static Geography MultiPointFromText(string multiPointWellKnownText, int coordinateSystemId)
        {
            Check.NotNull(multiPointWellKnownText, "multiPointWellKnownText");
            return null;
        }

        /// <summary>Returns the multi polygon value from a well-known text value.</summary>
        /// <returns>The multi polygon value from a well-known text value.</returns>
        /// <param name="multiPolygonWellKnownText">The multi polygon well-known text value.</param>
        /// <param name="coordinateSystemId">The coordinate system identifier.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi",
            Justification = "Match OGC, EDM")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "multi",
            Justification = "Match OGC, EDM")]
        public static Geography MultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId)
        {
            Check.NotNull(multiPolygonWellKnownText, "multiPolygonWellKnownText");
            return null;
        }

        /// <summary>
        /// Creates a new <see cref="T:System.Spatial.Geography" /> collection value based on the specified well known text value and coordinate system identifier (SRID).
        /// </summary>
        /// <returns>A new Geography value as defined by the well known text value with the specified coordinate system identifier.</returns>
        /// <param name="geographyCollectionWellKnownText">A string that contains a well known text representation of the geography value.</param>
        /// <param name="coordinateSystemId">The identifier of the coordinate system that the new Geography value should use.</param>
        public static Geography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId)
        {
            Check.NotNull(geographyCollectionWellKnownText, "geographyCollectionWellKnownText");
            return null;
        }

        #endregion

        #region Geography Instance Properties

        /// <summary>Gets the identifier associated with the coordinate system.</summary>
        /// <returns>The identifier associated with the coordinate system.</returns>
        public int CoordinateSystemId { get; set; }

        /// <summary>
        /// Gets the dimension of the given <see cref="T:System.Spatial.Geography" /> value or, if the value is a collections, the largest element dimension.
        /// </summary>
        /// <returns>
        /// The dimension of the given <see cref="T:System.Spatial.Geography" /> value.
        /// </returns>
        public int Dimension { get; set; }

        /// <summary>Gets the spatial type name of the Geography.</summary>
        /// <returns>The spatial type name of the Geography.</returns>
        public string SpatialTypeName { get; set; }

        /// <summary>Gets a nullable Boolean value indicating whether this Geography value is empty.</summary>
        /// <returns>True if this Geography value is empty; otherwise, false.</returns>
        public bool IsEmpty { get; set; }

        #endregion

        #region Geography Well Known Format Conversion

        /// <summary> Generates the well known text representation of this Geography value.  Includes only Longitude and Latitude for points. </summary>
        /// <returns>A string containing the well known text representation of this Geography value.</returns>
        public virtual string AsText()
        {
            return null;
        }

        // <summary>
        // Generates the well known text representation of this Geography value.  Includes Longitude, Latitude, Elevation (Z) and Measure (M) for points.
        // </summary>
        // <returns> A string containing the well known text representation of this Geography value. </returns>
        internal string AsTextIncludingElevationAndMeasure()
        {
            return null;
        }

        /// <summary> Generates the well known binary representation of this Geography value. </summary>
        /// <returns>The well-known binary representation of this Geography value.</returns>
        public byte[] AsBinary()
        {
            return null;
        }

        // Non-OGC
        /// <summary> Generates the Geography Markup Language (GML) representation of this Geography value. </summary>
        /// <returns>A string containing the GML representation of this Geography value.</returns>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Gml")]
        public string AsGml()
        {
            return null;
        }

        #endregion

        #region Geography Operations - Spatial Relation

        /// <summary> Determines whether this Geography is spatially equal to the specified Geography argument. </summary>
        /// <returns>true if other is spatially equal to this geography value; otherwise false.</returns>
        /// <param name="other">The geography value that should be compared with this geography value for equality.</param>
        public bool SpatialEquals(Geography other)
        {
            Check.NotNull(other, "other");
            return false;
        }

        /// <summary> Determines whether this Geography is spatially disjoint from the specified Geography argument. </summary>
        /// <returns>true if other is disjoint from this geography value; otherwise false.</returns>
        /// <param name="other">The geography value that should be compared with this geography value for disjointness.</param>
        public bool Disjoint(Geography other)
        {
            Check.NotNull(other, "other");
            return false;
        }

        /// <summary> Determines whether this Geography value spatially intersects the specified Geography argument. </summary>
        /// <returns>true if other intersects this geography value; otherwise false.</returns>
        /// <param name="other">The geography value that should be compared with this geography value for intersection.</param>
        public bool Intersects(Geography other)
        {
            Check.NotNull(other, "other");
            return false;
        }

        #endregion

        #region Geography Operations - Spatial Analysis

        /// <summary>Returns a geography object that represents the union of all points whose distance from a geography instance is less than or equal to a specified value.</summary>
        /// <returns>A geography object that represents the union of all points</returns>
        /// <param name="distance">The distance.</param>
        public Geography Buffer(double? distance)
        {
            Check.NotNull(distance, "distance");

            return null;
        }

        /// <summary> Computes the distance between the closest points in this Geography value and another Geography value. </summary>
        /// <returns>A double value that specifies the distance between the two closest points in this geography value and other.</returns>
        /// <param name="other">The geography value for which the distance from this value should be computed.</param>
        public double? Distance(Geography other)
        {
            Check.NotNull(other, "other");
            return null;
        }

        /// <summary> Computes the intersection of this Geography value and another Geography value. </summary>
        /// <returns>A new Geography value representing the intersection between this geography value and other.</returns>
        /// <param name="other">The geography value for which the intersection with this value should be computed.</param>
        public Geography Intersection(Geography other)
        {
            Check.NotNull(other, "other");
            return null;
        }

        /// <summary> Computes the union of this Geography value and another Geography value. </summary>
        /// <returns>A new Geography value representing the union between this geography value and other.</returns>
        /// <param name="other">The geography value for which the union with this value should be computed.</param>
        public Geography Union(Geography other)
        {
            Check.NotNull(other, "other");
            return null;
        }

        /// <summary> Computes the difference of this Geography value and another Geography value. </summary>
        /// <returns>A new Geography value representing the difference between this geography value and other.</returns>
        /// <param name="other">The geography value for which the difference with this value should be computed.</param>
        public Geography Difference(Geography other)
        {
            Check.NotNull(other, "other");
            return null;
        }

        /// <summary> Computes the symmetric difference of this Geography value and another Geography value. </summary>
        /// <returns>A new Geography value representing the symmetric difference between this geography value and other.</returns>
        /// <param name="other">The geography value for which the symmetric difference with this value should be computed.</param>
        public Geography SymmetricDifference(Geography other)
        {
            Check.NotNull(other, "other");
            return null;
        }

        #endregion

        #region Geography Collection

        /// <summary> Gets the number of elements in this Geography value, if it represents a geography collection. &lt;returns&gt;The number of elements in this geography value, if it represents a collection of other geography values; otherwise null.&lt;/returns&gt;</summary>
        /// <returns>The number of elements in this Geography value.</returns>
        public int? ElementCount { get; }

        /// <summary> Returns an element of this Geography value from a specific position, if it represents a geography collection. &lt;param name="index"&gt;The position within this geography value from which the element should be taken.&lt;/param&gt;&lt;returns&gt;The element in this geography value at the specified position, if it represents a collection of other geography values; otherwise null.&lt;/returns&gt;</summary>
        /// <returns>An element of this Geography value from a specific position</returns>
        /// <param name="index">The index.</param>
        public Geography ElementAt(int index)
        {
            return null;
        }

        #endregion

        #region Point

        /// <summary> Gets the Latitude coordinate of this Geography value, if it represents a point. &lt;returns&gt;The Latitude coordinate value of this geography value, if it represents a point; otherwise null.&lt;/returns&gt;</summary>
        /// <returns>The Latitude coordinate of this Geography value.</returns>
        public double? Latitude { get; }

        /// <summary> Gets the Longitude coordinate of this Geography value, if it represents a point. &lt;returns&gt;The Longitude coordinate value of this geography value, if it represents a point; otherwise null.&lt;/returns&gt;</summary>
        /// <returns>The Longitude coordinate of this Geography value.</returns>
        public double? Longitude { get; }

        /// <summary> Gets the elevation (Z coordinate) of this Geography value, if it represents a point. &lt;returns&gt;The elevation (Z coordinate) value of this geography value, if it represents a point; otherwise null.&lt;/returns&gt;</summary>
        /// <returns>The elevation (Z coordinate) of this Geography value.</returns>
        public double? Elevation { get; }

        /// <summary> Gets the M (Measure) coordinate of this Geography value, if it represents a point. &lt;returns&gt;The M (Measure) coordinate value of this geography value, if it represents a point; otherwise null.&lt;/returns&gt;</summary>
        /// <returns>The M (Measure) coordinate of this Geography value.</returns>
        public double? Measure { get; }

        #endregion

        #region Curve

        /// <summary> Gets a nullable double value that indicates the length of this Geography value, which may be null if this value does not represent a curve. </summary>
        /// <returns>A nullable double value that indicates the length of this Geography value.</returns>
        public double? Length { get; }

        /// <summary> Gets a Geography value representing the start point of this value, which may be null if this Geography value does not represent a curve. </summary>
        /// <returns>A Geography value representing the start point of this value.</returns>
        public Geography StartPoint { get; }

        /// <summary> Gets a Geography value representing the start point of this value, which may be null if this Geography value does not represent a curve. </summary>
        /// <returns>A Geography value representing the start point of this value.</returns>
        public Geography EndPoint { get; }

        /// <summary> Gets a nullable Boolean value indicating whether this Geography value is closed, which may be null if this value does not represent a curve. </summary>
        /// <returns>True if this Geography value is closed; otherwise, false.</returns>
        public bool? IsClosed { get; }

        #endregion

        #region LineString, Line, LinearRing

        /// <summary> Gets the number of points in this Geography value, if it represents a linestring or linear ring. &lt;returns&gt;The number of elements in this geography value, if it represents a linestring or linear ring; otherwise null.&lt;/returns&gt;</summary>
        /// <returns>The number of points in this Geography value.</returns>
        public int? PointCount { get; }

        /// <summary> Returns an element of this Geography value from a specific position, if it represents a linestring or linear ring. &lt;param name="index"&gt;The position within this geography value from which the element should be taken.&lt;/param&gt;&lt;returns&gt;The element in this geography value at the specified position, if it represents a linestring or linear ring; otherwise null.&lt;/returns&gt;</summary>
        /// <returns>An element of this Geography value from a specific position</returns>
        /// <param name="index">The index.</param>
        public Geography PointAt(int index)
        {
            return null;
        }

        #endregion

        #region Surface

        /// <summary> Gets a nullable double value that indicates the area of this Geography value, which may be null if this value does not represent a surface. </summary>
        /// <returns>A nullable double value that indicates the area of this Geography value.</returns>
        public double? Area { get; }

        #endregion

        #region ToString

        /// <summary> Returns a string representation of the geography value. </summary>
        /// <returns>A string representation of the geography value.</returns>
        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture, "SRID={1};{0}", WellKnownValue.WellKnownText ?? base.ToString(), CoordinateSystemId);
        }

        #endregion
    }
}
