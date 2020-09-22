import { handleResponse, handleError } from './apiUtils'
const baseUrl = process.env.VEHICLE_API_URL + '/api/vehicle/'

export function getVehicle() {
  return fetch(baseUrl).then(handleResponse).catch(handleError)
}

export function createVehicle(vehicleType, vehicle) {
  console.log(
    JSON.stringify({
      ...vehicle,
    }),
  )

  return fetch(baseUrl + vehicleType, {
    method: 'post',
    headers: { 'content-type': 'application/json' },
    body: JSON.stringify({
      ...vehicle,
    }),
  })
    .then(handleResponse)
    .catch(handleError)
}
