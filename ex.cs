// Assuming DELAY_BETWEEN_DAYS_IN_S is a predefined constant and profiles is a collection.
const double delayPerProfile = DELAY_BETWEEN_DAYS_IN_S / profiles.Count;
var optimizedResult = profiles.Select(m => (int)Math.Floor(delayPerProfile * m)).ToList();
