export function unixSecondsToYear(unixSeconds: number): number {
  const millisecondsPerSecond = 1000
  return new Date(millisecondsPerSecond * unixSeconds).getFullYear()
}
