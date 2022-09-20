package perfectnumbers

import (
	"reflect"
	"testing"
)

func AssertEqual(testing *testing.T, a interface{}, b interface{}) {
	if !reflect.DeepEqual(a, b) {
		testing.Errorf("Received %v (type %v), expected %v (type %v)", a, reflect.TypeOf(a), b, reflect.TypeOf(b))
	}
}

func TestCanary(testing *testing.T) {
	AssertEqual(testing, true, true)
}

func TestSumOfFactors(testing *testing.T) {
	testCases := []struct {
		input    int
		expected int
	}{
		{6, 12},
		{50, 93},
	}

	for _, tc := range testCases {
		got := sumOfFactors(tc.input)
		AssertEqual(testing, got, tc.expected)
	}
}

func SetOfTestsForIsPerfect(testing *testing.T, isPerfect func(int) bool) {
	testCases := []struct {
		input    int
		expected bool
	}{
		{6, true},
		{28, true},
		{496, true},
		{8128, true},
		{33550336, true},
		{33550337, false},
		{33550338, false},
	}

	for _, tc := range testCases {
		got := isPerfect(tc.input)
		AssertEqual(testing, got, tc.expected)
	}
}

func TestIsPerfectImperative(testing *testing.T) {
	SetOfTestsForIsPerfect(testing, IsPerfectImperative)
}

func TestIsPerfectFunctional(testing *testing.T) {
	SetOfTestsForIsPerfect(testing, IsPerfectFunctional)
}