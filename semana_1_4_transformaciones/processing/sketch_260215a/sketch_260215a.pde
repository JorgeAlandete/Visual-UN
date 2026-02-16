void setup() {
  size(600, 600, P3D);  // Activate 3D
}

void draw() {
  background(30);
  lights();

  float t = millis() / 1000.0;  // Time in seconds

  pushMatrix();

  float x = sin(t) * 150;
  translate(width/2 + x, height/2, 0);

  rotateX(t);
  rotateY(t * 0.7);

  float s = 1 + 0.5 * sin(t * 2);
  scale(s);

  box(80);

  popMatrix();
}
