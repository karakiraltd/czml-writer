﻿// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;
using System.Drawing;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>CheckerboardMaterial</c> to a <see cref="CesiumOutputStream"/>. A <c>CheckerboardMaterial</c> is a material that fills the surface with a checkerboard pattern.
    /// </summary>
    public class CheckerboardMaterialCesiumWriter : CesiumPropertyWriter<CheckerboardMaterialCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>evenColor</c> property.
        /// </summary>
        public const string EvenColorPropertyName = "evenColor";

        /// <summary>
        /// The name of the <c>oddColor</c> property.
        /// </summary>
        public const string OddColorPropertyName = "oddColor";

        /// <summary>
        /// The name of the <c>repeat</c> property.
        /// </summary>
        public const string RepeatPropertyName = "repeat";

        private readonly Lazy<ColorCesiumWriter> m_evenColor = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(EvenColorPropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_oddColor = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(OddColorPropertyName), false);
        private readonly Lazy<RepeatCesiumWriter> m_repeat = new Lazy<RepeatCesiumWriter>(() => new RepeatCesiumWriter(RepeatPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public CheckerboardMaterialCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected CheckerboardMaterialCesiumWriter([NotNull] CheckerboardMaterialCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc/>
        public override CheckerboardMaterialCesiumWriter Clone()
        {
            return new CheckerboardMaterialCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>evenColor</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>evenColor</c> property defines the even color. If not specified, the default value is white.
        /// </summary>
        [NotNull]
        public ColorCesiumWriter EvenColorWriter
        {
            get { return m_evenColor.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>evenColor</c> property. The <c>evenColor</c> property defines the even color. If not specified, the default value is white.
        /// </summary>
        [NotNull]
        public ColorCesiumWriter OpenEvenColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(EvenColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>rgba</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteEvenColorProperty(Color color)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>rgba</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteEvenColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>rgba</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteEvenColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>rgba</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteEvenColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>rgbaf</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteEvenColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>rgbaf</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteEvenColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>rgbaf</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteEvenColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>rgbaf</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteEvenColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>reference</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteEvenColorPropertyReference(Reference value)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>reference</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteEvenColorPropertyReference(string value)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>reference</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteEvenColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>evenColor</c> property as a <c>reference</c> value. The <c>evenColor</c> property specifies the even color. If not specified, the default value is white.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteEvenColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenEvenColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>oddColor</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>oddColor</c> property defines the odd color. If not specified, the default value is black.
        /// </summary>
        [NotNull]
        public ColorCesiumWriter OddColorWriter
        {
            get { return m_oddColor.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>oddColor</c> property. The <c>oddColor</c> property defines the odd color. If not specified, the default value is black.
        /// </summary>
        [NotNull]
        public ColorCesiumWriter OpenOddColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(OddColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>rgba</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteOddColorProperty(Color color)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>rgba</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteOddColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>rgba</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteOddColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>rgba</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteOddColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>rgbaf</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteOddColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>rgbaf</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteOddColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>rgbaf</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteOddColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>rgbaf</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteOddColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>reference</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteOddColorPropertyReference(Reference value)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>reference</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteOddColorPropertyReference(string value)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>reference</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteOddColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>oddColor</c> property as a <c>reference</c> value. The <c>oddColor</c> property specifies the odd color. If not specified, the default value is black.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteOddColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenOddColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>repeat</c> property. The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing. The <c>repeat</c> property defines the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        [NotNull]
        public RepeatCesiumWriter RepeatWriter
        {
            get { return m_repeat.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>repeat</c> property. The <c>repeat</c> property defines the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        [NotNull]
        public RepeatCesiumWriter OpenRepeatProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(RepeatWriter);
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>cartesian2</c> value. The <c>repeat</c> property specifies the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteRepeatProperty(Rectangular value)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>cartesian2</c> value. The <c>repeat</c> property specifies the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public void WriteRepeatProperty(double x, double y)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(x, y);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>cartesian2</c> value. The <c>repeat</c> property specifies the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteRepeatProperty(IList<JulianDate> dates, IList<Rectangular> values)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>cartesian2</c> value. The <c>repeat</c> property specifies the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteRepeatProperty(IList<JulianDate> dates, IList<Rectangular> values, int startIndex, int length)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteCartesian2(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>reference</c> value. The <c>repeat</c> property specifies the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRepeatPropertyReference(Reference value)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>reference</c> value. The <c>repeat</c> property specifies the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteRepeatPropertyReference(string value)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>reference</c> value. The <c>repeat</c> property specifies the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteRepeatPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>repeat</c> property as a <c>reference</c> value. The <c>repeat</c> property specifies the number of times the tiles repeat along each axis. If not specified, the default value is [2, 2].
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteRepeatPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenRepeatProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
