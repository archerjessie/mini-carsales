import React, { useState } from 'react'
import PropTypes from 'prop-types'

const CarCreationForm = (props) => {
  const { createCar } = props
  const [make, setMake] = useState('')
  const [model, setModel] = useState('')
  const [engine, setEngine] = useState('')
  const [doors, setDoors] = useState('')
  const [wheels, setWheels] = useState('')
  const [bodyType, setBodyType] = useState('')

  const onChange = (event) => {
    switch (event.target.id) {
      case 'car-make':
        setMake(event.target.value)
        break
      case 'car-model':
        setModel(event.target.value)
        break
      case 'car-engine':
        setEngine(event.target.value)
        break
      case 'car-doors':
        setDoors(event.target.value)
        break
      case 'car-wheels':
        setWheels(event.target.value)
        break
      case 'car-body':
        setBodyType(event.target.value)
        break
    }
  }

  const handleSubmit = (event) => {
    event.preventDefault()
    let car = {
      make,
      model,
      engine,
      doors,
      wheels,
      bodyType,
    }
    createCar(car)

    setMake('')
    setModel('')
    setEngine('')
    setDoors('')
    setWheels('')
    setBodyType('')
  }

  return (
    <form onSubmit={handleSubmit}>
      <div className="form-row">
        <div className="col-md-6 mb-3">
          <label htmlFor="car-make">Make</label>
          <input
            type="text"
            className="form-control"
            id="car-make"
            value={make}
            onChange={onChange}
            required
          ></input>
        </div>
        <div className="col-md-6 mb-3">
          <label htmlFor="car-model">Model</label>
          <input
            type="text"
            className="form-control"
            id="car-model"
            value={model}
            onChange={onChange}
            required
          ></input>
        </div>
      </div>
      <div className="form-row">
        <div className="col-md-6 mb-3">
          <label htmlFor="car-engine">Engine</label>
          <input
            type="text"
            className="form-control"
            id="car-engine"
            value={engine}
            onChange={onChange}
          ></input>
        </div>
        <div className="col-md-6 mb-3">
          <label htmlFor="car-body">Body Type</label>
          <input
            type="text"
            className="form-control"
            id="car-body"
            value={bodyType}
            onChange={onChange}
          ></input>
        </div>
      </div>
      <div className="form-row">
        <div className="col-md-6 mb-3">
          <label htmlFor="car-doors"># Doors</label>
          <select
            className="custom-select"
            id="car-doors"
            onChange={onChange}
            value={doors}
            required
          >
            <option value=""></option>
            {[1, 2, 3, 4, 5, 6, 7, 8].map((selection) => (
              <option key={selection} value={selection}>
                {selection}
              </option>
            ))}
          </select>
        </div>
        <div className="col-md-6 mb-3">
          <label htmlFor="car-wheels"># Wheels</label>
          <select
            className="custom-select"
            id="car-wheels"
            onChange={onChange}
            value={wheels}
            required
          >
            <option value=""></option>
            {[1, 2, 3, 4, 5, 6, 7, 8].map((selection) => (
              <option key={selection} value={selection}>
                {selection}
              </option>
            ))}
          </select>
        </div>
      </div>
      <button className="btn btn-primary" type="submit">
        Submit
      </button>
    </form>
  )
}

CarCreationForm.prototype = {
  createCar: PropTypes.func.isRequired,
}

export default CarCreationForm
