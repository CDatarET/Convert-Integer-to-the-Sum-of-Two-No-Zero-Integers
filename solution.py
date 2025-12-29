class Solution:
    def hasZero(self, n):
        while n > 0:
            if n % 10 == 0:
                return True
            
            n //= 10
        
        return False

    def getNoZeroIntegers(self, n):
        r = n - 1
        for i in range(1, n):
            if not self.hasZero(i) and not self.hasZero(r):
                return [i, r]

            r -= 1
