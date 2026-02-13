# Taller Construyendo Mundo 3D
Sebastián Andrade Cedano 

Entregado el: 11 Feb 2022

## Objetivo
El objetivo del taller consistía en cargar modelos 3D en distintos motores gráficos (three.js dentro de React y Python). Para comprender el proceso de carga del modelo y la geometría que lo compone (caras, vertices, etc).

## Implementaciones
### Three.js con Rect three fiber
Para poder realizar esta implementación se siguieron los siguientes pasos:
1. Iniciar proyecto de React.js con Vite
2. Instalar dependencias necesarias
3. Descargar un modelo .gltf
4. Crear un componente de React el cual cargue el modelo
5. Insertar este componente en el componente de Aplicación

A continuación se muestra el componente en React del modelo 3D

```
import { useGLTF } from "@react-three/drei";

function Model() {
  const { scene } = useGLTF("/models/scene.gltf");

  scene.traverse((child) => {
    if (child.isMesh) { // If this thing is renderable
      child.material.wireframe = true; // Set to false for rendering the textures, true to render only the borders and see the triangles themselves
    }
  });

  return <primitive object={scene} />;
}

export default Model; 
```
#### Modelo cargado en la aplicación
<img src="./media/bear_solid_js.png" alt="Sample Image" width="400"/>


#### Triángulos del modelo dibujados con wireframe
<img src="./media/bear_triangles.png" alt="Sample Image" width="400"/>

### Python con Open3D y Ploty
Para poder realizar esta implementación se siguieron los siguientes pasos:
1. Instalar tanto Open3D como Ploty usando pip
2. Cargar el mesh del archivo .obj usando o3d
3. Computar los normales
4. Usar mesh3d para las caras y Scatter para los vertices (ambos de ploty)
5. Imprimir la imagen usando ploty

#### Modelo cargado en colab
<img src="./media/bunny_python.png" alt="Sample Image" width="400"/>


#### Datos de vértices y aristas en Python
<img src="./media/bunny_dots.png" alt="Sample Image" width="400"/>

## Aprendizajes y dificultadoes
* Es dificil utilizar algunas librerías para hacer el render de los modelos cuando se trabaja en Colab, puesto que estas pueden presentar errores.
* El tamaño del modelo puede generar problemas al cargarlo.

## Referencias
* [Open3D Visualize in Google Colab](https://colab.research.google.com/drive/1CR_HDvJ2AnjJV3Bf5vwP70K0hx3RcdMb)
