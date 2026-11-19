import { useEffect, useState } from 'react'
import { getHealth } from './api'

function App() {
  const [status, setStatus] = useState('checking...')

  useEffect(() => {
    getHealth()
      .then((result) => setStatus(result.status))
      .catch(() => setStatus('unreachable'))
  }, [])

  return (
    <main>
      <h1>EducationCentre (React)</h1>
      <p>API status: {status}</p>
    </main>
  )
}

export default App
