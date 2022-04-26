describe('Test Suite', () => {
    it('test 1', () => {
        expect(yahtzeeFunction("Ones", [1, 2, 3, 4, 5])).toBe(1)
    });
    xit('test 2', () => {
        expect(yahtzeeFunction("Twos", [1, 2, 3, 2, 5])).toBe(4)
    });
})