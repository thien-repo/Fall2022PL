(defun fibonacci-iterative (num)
  (cond ((eq num 0) (list 1))
        ((let ((result (list 1 1)))
             (loop for i from 2 to num
                   do (nconc result  (list (+ (nth (- i 1) result)
                                              (nth (- i 2) result)))))
             result))))

(defun fibonacci-recursive (num)
  (cond ((eq num 0) (list 1))
        ((eq num 1) (list 1 1))
        ((let ((result (fibonacci-recursive (- num 1))))
             (nconc result (list (+ (first (last result 2))
                                    (second (last result 2)))))))))

(defun fibonacci-tail-recursive (num &optional (result (list 1 1)))
  (cond ((eq num 0) (list 1))
        ((eq num 1) result)
        ((fibonacci-tail-recursive (- num 1) 
                                   (nconc result (list (+ (first (last result 2))
                                                          (second (last result 2)))))))))
                                     

