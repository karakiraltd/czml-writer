package cesiumlanguagewritertests;


import agi.foundation.compatibility.*;
import agi.foundation.compatibility.ConsoleHelper;
import agi.foundation.compatibility.DisposeHelper;
import agi.foundation.compatibility.TestContextRule;
import cesiumlanguagewriter.*;
import cesiumlanguagewriter.advanced.*;
import java.io.StringWriter;
import java.util.ArrayList;
import java.util.Collection;
import javax.annotation.Nonnull;
import org.junit.Assert;
import org.junit.FixMethodOrder;
import org.junit.Rule;
import org.junit.runners.MethodSorters;
import org.junit.Test;

@SuppressWarnings( {
        "unused",
        "deprecation",
        "serial"
})
@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class TestOrientationCesiumWriter extends TestCesiumInterpolatablePropertyWriter<OrientationCesiumWriter> {
    @Test
    public final void testCompleteExample() {
        JulianDate date = new JulianDate(2451545.0);
        final String id = "MyID";
        TimeInterval availability = new TimeInterval(date, date.addDays(2.0));
        TimeInterval interval1 = new TimeInterval(date, date.addDays(1.0));
        Cartesian interval1Position = new Cartesian(1.0, 2.0, 3.0);
        UnitQuaternion interval1Orientation = new UnitQuaternion(1D, 0D, 0D, 0D);
        TimeInterval interval2 = new TimeInterval(date.addDays(1.0), date.addDays(2.0));
        final ArrayList<cesiumlanguagewriter.JulianDate> tempCollection$0 = new ArrayList<cesiumlanguagewriter.JulianDate>();
        tempCollection$0.add(date.addDays(1.0));
        tempCollection$0.add(date.addDays(1.5));
        tempCollection$0.add(date.addDays(2.0));
        ArrayList<cesiumlanguagewriter.JulianDate> interval2SampleDates = tempCollection$0;
        final ArrayList<cesiumlanguagewriter.Cartographic> tempCollection$1 = new ArrayList<cesiumlanguagewriter.Cartographic>();
        tempCollection$1.add(Cartographic.getZero());
        tempCollection$1.add(new Cartographic(1.0, 0.0, 0.0));
        tempCollection$1.add(new Cartographic(0.0, 1.0, 0.0));
        ArrayList<cesiumlanguagewriter.Cartographic> interval2SamplePositions = tempCollection$1;
        final ArrayList<cesiumlanguagewriter.UnitQuaternion> tempCollection$2 = new ArrayList<cesiumlanguagewriter.UnitQuaternion>();
        tempCollection$2.add(UnitQuaternion.getIdentity());
        tempCollection$2.add(new UnitQuaternion(0.0, 1.0, 0.0, 0.0));
        tempCollection$2.add(new UnitQuaternion(0.0, 0.0, 1.0, 0.0));
        ArrayList<cesiumlanguagewriter.UnitQuaternion> interval2SampleOrientations = tempCollection$2;
        final CesiumInterpolationAlgorithm orientationInterpolationAlgorithm = CesiumInterpolationAlgorithm.LINEAR;
        final int orientationInterpolationDegree = 1;
        final CesiumOutputStream tempObj$0 = new CesiumOutputStream(getStringWriter());
        tempObj$0.setPrettyFormatting(true);
        CesiumOutputStream outputStream = tempObj$0;
        CesiumStreamWriter writer = new CesiumStreamWriter();
        {
            PacketCesiumWriter packet = writer.openPacket(outputStream);
            try {
                packet.writeId(id);
                packet.writeAvailability(availability);
                {
                    PositionCesiumWriter positionWriter = packet.openPositionProperty();
                    try {
                        {
                            CesiumIntervalListWriter<cesiumlanguagewriter.PositionCesiumWriter> intervalListWriter = positionWriter.openMultipleIntervals();
                            try {
                                {
                                    PositionCesiumWriter interval = intervalListWriter.openInterval();
                                    try {
                                        interval.writeInterval(interval1);
                                        interval.writeCartesian(interval1Position);
                                    } finally {
                                        DisposeHelper.dispose(interval);
                                    }
                                }
                                {
                                    PositionCesiumWriter interval = intervalListWriter.openInterval(interval2.getStart(), interval2.getStop());
                                    try {
                                        interval.writeCartographicRadians(interval2SampleDates, interval2SamplePositions);
                                    } finally {
                                        DisposeHelper.dispose(interval);
                                    }
                                }
                            } finally {
                                DisposeHelper.dispose(intervalListWriter);
                            }
                        }
                    } finally {
                        DisposeHelper.dispose(positionWriter);
                    }
                }
                {
                    OrientationCesiumWriter orientationWriter = packet.openOrientationProperty();
                    try {
                        {
                            CesiumIntervalListWriter<cesiumlanguagewriter.OrientationCesiumWriter> intervalListWriter = orientationWriter.openMultipleIntervals();
                            try {
                                {
                                    OrientationCesiumWriter interval = intervalListWriter.openInterval();
                                    try {
                                        interval.writeInterval(interval1);
                                        interval.writeUnitQuaternion(interval1Orientation);
                                    } finally {
                                        DisposeHelper.dispose(interval);
                                    }
                                }
                                {
                                    OrientationCesiumWriter interval = intervalListWriter.openInterval(interval2.getStart(), interval2.getStop());
                                    try {
                                        interval.writeInterpolationAlgorithm(orientationInterpolationAlgorithm);
                                        interval.writeInterpolationDegree(orientationInterpolationDegree);
                                        interval.writeUnitQuaternion(interval2SampleDates, interval2SampleOrientations);
                                    } finally {
                                        DisposeHelper.dispose(interval);
                                    }
                                }
                            } finally {
                                DisposeHelper.dispose(intervalListWriter);
                            }
                        }
                    } finally {
                        DisposeHelper.dispose(orientationWriter);
                    }
                }
            } finally {
                DisposeHelper.dispose(packet);
            }
        }
        ConsoleHelper.writeLine(getStringWriter().toString());
    }

    @Test
    public final void testDeletePropertyWithStartAndStop() {
        JulianDate start = new JulianDate(new GregorianDate(2012, 4, 2, 12, 0, 0D));
        JulianDate stop = start.addDays(1.0);
        {
            final PacketCesiumWriter usingExpression_0 = (getPacket());
            try {
                getPacket().writeId("id");
                {
                    OrientationCesiumWriter orientation = getPacket().openOrientationProperty();
                    try {
                        {
                            OrientationCesiumWriter interval = orientation.openInterval(start, stop);
                            try {
                                interval.writeDelete(true);
                            } finally {
                                DisposeHelper.dispose(interval);
                            }
                        }
                    } finally {
                        DisposeHelper.dispose(orientation);
                    }
                }
            } finally {
                DisposeHelper.dispose(usingExpression_0);
            }
        }
        Assert.assertEquals("{\"id\":\"id\",\"orientation\":{\"interval\":\"20120402T12Z/20120403T12Z\",\"delete\":true}}", getStringWriter().toString());
    }

    @Test
    public final void testDeletePropertyWithNoInterval() {
        {
            final PacketCesiumWriter usingExpression_1 = (getPacket());
            try {
                getPacket().writeId("id");
                {
                    OrientationCesiumWriter orientation = getPacket().openOrientationProperty();
                    try {
                        {
                            OrientationCesiumWriter interval = orientation.openInterval();
                            try {
                                interval.writeDelete(true);
                            } finally {
                                DisposeHelper.dispose(interval);
                            }
                        }
                    } finally {
                        DisposeHelper.dispose(orientation);
                    }
                }
            } finally {
                DisposeHelper.dispose(usingExpression_1);
            }
        }
        Assert.assertEquals("{\"id\":\"id\",\"orientation\":{\"delete\":true}}", getStringWriter().toString());
    }

    @Override
    protected CesiumPropertyWriter<OrientationCesiumWriter> createPropertyWriter(String propertyName) {
        return new OrientationCesiumWriter(propertyName);
    }

    @Nonnull
    private final TestContextRule rule$testContext = new TestContextRule();

    @Nonnull
    @Rule
    public TestContextRule getRule$testContext() {
        return rule$testContext;
    }
}