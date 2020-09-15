import React from 'react'
import PropTypes from 'prop-types'

const VehicleList = (props) => (
  <table className="table table-striped">
    <thead>
      <tr>
        <th scope="col">Id</th>
        <th scope="col">Make</th>
        <th scope="col">Model</th>
        <th scope="col">Engine</th>
        <th scope="col">Doors</th>
        <th scope="col">Wheels</th>
        <th scope="col">Body type</th>
      </tr>
    </thead>
    <tbody>
      {props.vehicles.map((vehicle) => (
        <tr key={vehicle.id}>
          <td>{vehicle.id}</td>
          <td>{vehicle.make}</td>
          <td>{vehicle.model}</td>
          <td>{vehicle.engine}</td>
          <td>{vehicle.doors}</td>
          <td>{vehicle.wheels}</td>
          <td>{vehicle.bodyType}</td>
        </tr>
      ))}
    </tbody>
  </table>
)

VehicleList.prototype = {
  vehicles: PropTypes.arrayOf(
    PropTypes.shape({
      id: PropTypes.number.isRequired,
      make: PropTypes.string.isRequired,
      model: PropTypes.string.isRequired,
      engine: PropTypes.string.isRequired,
      doors: PropTypes.number.isRequired,
      wheels: PropTypes.string.isRequired,
      bodyType: PropTypes.string.isRequired,
    }),
  ),
}

export default VehicleList
