#   -*- coding: utf-8 -*-
from pybuilder.core import use_plugin, init

use_plugin("python.core")
use_plugin("python.unittest")
use_plugin("python.flake8")
use_plugin("python.coverage")
use_plugin("python.distutils")


name = "PerfectNumber"
default_task = "publish"


@init
def set_properties(project):
    project.set_property("run_unit_tests_command", "py.test %s" % project.expand_path("$dir_source_unittest_python"))
    project.set_property("run_unit_tests_propagate_stdout", True)
    project.set_property("run_unit_tests_propagate_stderr", True)
