using System;

public class RobotArm
{
    public double Link1 { get; }
    public double Link2 { get; }

    public RobotArm(double link1, double link2)
    {
        Link1 = link1;
        Link2 = link2;
    }

    // İleri kinematik: açıları alıp X, Y konumunu döndürür
    public (double x, double y) ForwardKinematics(double theta1Deg, double theta2Deg)
    {
        double theta1 = theta1Deg * Math.PI / 180.0;
        double theta2 = theta2Deg * Math.PI / 180.0;

        double x = Link1 * Math.Cos(theta1) + Link2 * Math.Cos(theta1 + theta2);
        double y = Link1 * Math.Sin(theta1) + Link2 * Math.Sin(theta1 + theta2);

        return (x, y);
    }
}