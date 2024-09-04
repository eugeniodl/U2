public class Vector3D
{
    public double X { get; private set; }
    public double Y { get; private set; }
    public double Z { get; private set; }

    // Constructor para inicializar el vector con tres componentes
    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Método para sumar dos vectores
    public Vector3D Sumar(Vector3D otro)
    {
        return new Vector3D(X + otro.X, Y + otro.Y, Z + otro.Z);
    }

    // Método para calcular el producto escalar
    public double ProductoEscalar(Vector3D otro)
    {
        return X * otro.X + Y * otro.Y + Z * otro.Z;
    }

    // Método para representar el vector como una cadena de texto
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}

