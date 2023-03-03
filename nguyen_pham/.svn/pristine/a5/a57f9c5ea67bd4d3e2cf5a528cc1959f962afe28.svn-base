(load "lib/lisp-unit")
(load "src/sample")
(use-package :lisp-unit)

(define-test test-canary
  (assert-true t))

(define-test test-add-two
  (assert-equal 3 (add 1 2)))

(run-tests :all)
