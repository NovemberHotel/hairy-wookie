/*
 Robotics with the BOE Shield – LeftServoStayStill
 Generate signal to make the servo stay still for centering.
 */

#include <Servo.h>                           // Include servo library
 
Servo servo; 
int incomingByte = 0;
String receivedMessage = "" ;
boolean startReceiving = false;
int snelheid =1500;
int snelheidVooruit = 1550;
int snelheidAchteruit = 1450;
int snelheidStilstand = 1500;
const int pingPin =7;

void setup()                                 // Built in initialization block
{
  Serial.begin(9600);
  servo.attach(13);                      // Attach left signal to pin 13
  servo.writeMicroseconds(snelheid);   // 1.5 ms stay still signal
 
}  
 
void loop()                                  // Main loop auto-repeats
{   
  servo.writeMicroseconds(snelheid); 
       if (Serial.available() > 0) {
                // read the incoming byte:
                incomingByte = Serial.read();

                
                
                char receivedCharacter = (char) incomingByte;
                if(receivedCharacter == '#'){
                startReceiving = true;
                }
                if(startReceiving== true){
                receivedMessage +=(String) receivedCharacter;
                
                }
                if(receivedCharacter == '%'){
                 startReceiving = false; 
                  
                }
                
               
        } //Lees SerialLog
     
      
      if(receivedMessage== "#FWD%"){
       snelheid = snelheidVooruit; 
       receivedMessage = "" ;
      }
      
      if(receivedMessage == "#BACK%"){
        snelheid = snelheidAchteruit;
         receivedMessage = "" ;
      }
      
      if(receivedMessage == "#STOP%"){
       snelheid = snelheidStilstand; 
      receivedMessage = "" ;    
      }
  
  
      if(startReceiving==false && receivedMessage!= ""){
         receivedMessage= ""; 
      }
}//einde project
  
  
  
