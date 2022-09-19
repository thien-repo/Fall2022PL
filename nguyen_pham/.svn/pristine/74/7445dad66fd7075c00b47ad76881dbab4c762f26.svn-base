package assign1;

import org.junit.jupiter.api.Test;

import java.util.*;

import static org.junit.jupiter.api.Assertions.*; 

import java.util.function.Predicate;

public class PerfectNumberCheckerTest {
  @Test
  public void canary() { 
    assertTrue(true);
  }

  @Test
  void sumOfFactorsTests(){
    assertAll(
      () -> assertEquals(12, PerfectNumberChecker.sumOfFactors(6)),
      () -> assertEquals(93, PerfectNumberChecker.sumOfFactors(50))
    );
  }

  void testSetForIsPerfect(Predicate<Integer> isPerfect) {
    assertAll(
      () -> assertTrue(isPerfect.test(6)),
      () -> assertTrue(isPerfect.test(28)),
      () -> assertFalse(isPerfect.test(50)),
      () -> assertFalse(isPerfect.test(100)),
      () -> assertTrue(isPerfect.test(496)),
      ()-> assertFalse(isPerfect.test(500)),
      () -> assertTrue(isPerfect.test(8128))
    );
  }

  @Test
  void isPerfectTests(){
    testSetForIsPerfect(PerfectNumberChecker::isPerfectImperative);
  }

  @Test
  void functionalIsPerfectTests(){
    testSetForIsPerfect(PerfectNumberChecker::isPerfectFunctional);
  }
}
