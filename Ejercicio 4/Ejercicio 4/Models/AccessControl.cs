using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.Models
{
    public class AccessControl
    {
        private int validUser = 12;
        private int validPassword = 1234;
        private int attemptCount = 0;
        private int maxAttempts = 3;

        public bool ValidateLogin(int user, int password)
        {
            attemptCount++;
            if (user == validUser && password == validPassword)
            {
                return true;
            }
            if (attemptCount >= maxAttempts)
            {
                return false;
            }
            return false;
        }

        public bool HasAttemptsLeft()
        {
            return attemptCount < maxAttempts;
        }

        public int GetRemainingAttempts()
        {
            return maxAttempts - attemptCount;
        }

    }
}