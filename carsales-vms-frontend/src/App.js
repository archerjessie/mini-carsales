import React, { useState, useEffect } from 'react'
import { getVehicle, createVehicle } from './api/vehicleApi'
import VehicleList from './components/VehicleList'
import CarCreationForm from './components/CarCreationForm'
import './App.css'

function App() {
  const hide = { display: 'none' }
  const show = { display: 'block' }

  const [vehicles, setVehicles] = useState([])
  const [displayCarCreation, setDisplayCarCreation] = useState(hide)

  useEffect(() => {
    getVehicle().then((_vehicles) => setVehicles(_vehicles))
  }, [])

  const actionSelectionChanged = (event) => {
    switch (event.target.value) {
      case 'create car':
        setDisplayCarCreation(show)
        break
      default:
        setDisplayCarCreation(hide)
        break
    }
  }

  const createCar = (car) => {
    createVehicle('car', car).then(() =>
      getVehicle().then((_vehicles) => setVehicles(_vehicles)),
    )
  }

  return (
    <div className="container-lg">
      <section>
        <header>
          <h3>All Vehicles</h3>
        </header>
        <VehicleList vehicles={vehicles} />
      </section>
      <h3>Please Select</h3>
      <select
        className="custom-select"
        id="action-selection"
        onChange={actionSelectionChanged}
        required
      >
        <option>please select actions</option>
        <option value={'create car'}>create a new car</option>
      </select>

      <section style={displayCarCreation}>
        <header>
          <h3>Create a new car</h3>
        </header>
        <CarCreationForm createCar={createCar} />
      </section>
    </div>
  )
}

export default App
