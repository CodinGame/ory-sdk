"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v1.1.45
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.project_api_key import ProjectApiKey
globals()['ProjectApiKey'] = ProjectApiKey
from ory_client.model.project_api_keys import ProjectApiKeys


class TestProjectApiKeys(unittest.TestCase):
    """ProjectApiKeys unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testProjectApiKeys(self):
        """Test ProjectApiKeys"""
        # FIXME: construct object with mandatory attributes with example values
        # model = ProjectApiKeys()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
