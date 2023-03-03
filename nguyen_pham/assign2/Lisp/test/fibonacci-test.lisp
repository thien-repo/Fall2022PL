(load "lib/lisp-unit")
(load "src/fibonacci")
(use-package :lisp-unit)

(define-test test-canary
  (assert-true t))

(defun test-fibonacci (fibonacci)
  (assert-equal (funcall fibonacci 0) '(1))
  (assert-equal (funcall fibonacci 1) '(1 1))
  (assert-equal (funcall fibonacci 2) '(1 1 2))
  (assert-equal (funcall fibonacci 3) '(1 1 2 3))
  (assert-equal (funcall fibonacci 4) '(1 1 2 3 5))
  (assert-equal (funcall fibonacci 5) '(1 1 2 3 5 8))
  (assert-equal (funcall fibonacci 6) '(1 1 2 3 5 8 13)))

(define-test test-fibonacci-iterative
  (test-fibonacci #'fibonacci-iterative))

(define-test test-fibonacci-recursive
  (test-fibonacci #'fibonacci-recursive))

(define-test test-fibonacci-tail-recursive
  (test-fibonacci #'fibonacci-tail-recursive))
  
(run-tests :all)
