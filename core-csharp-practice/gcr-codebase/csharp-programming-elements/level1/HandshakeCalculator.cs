using System;
class HandshakeCalculator{
    static void Main(string[] args){
        int Students = int.Parse(Console.ReadLine());
        int handshakes = (Students * (Students - 1)) / 2;
        Console.WriteLine("The maximum number of handshakes is " + handshakes);
    }
}
