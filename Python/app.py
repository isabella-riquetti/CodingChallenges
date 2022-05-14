from flask import Flask
from LeetCode.Question0117.tests import SolutionTest

def create_app():
    app = Flask(__name__)
    @app.route('/')
    def test_solution():
        SolutionTest().test()
    return app
app = create_app()