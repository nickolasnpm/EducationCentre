const apiUrl = import.meta.env.VITE_API_URL as string

export async function getHealth(): Promise<{ status: string }> {
  const response = await fetch(`${apiUrl}/health`)
  if (!response.ok) {
    throw new Error(`API responded with ${response.status}`)
  }
  return response.json()
}
