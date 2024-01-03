# NOTE: This file is auto generated by OpenAPI Generator 6.6.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.CreateWorkspaceMemberInviteBody do
  @moduledoc """
  Create Workspace Invite Request Body
  """

  @derive [Poison.Encoder]
  defstruct [
    :invitee_email
  ]

  @type t :: %__MODULE__{
    :invitee_email => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.CreateWorkspaceMemberInviteBody do
  def decode(value, _options) do
    value
  end
end

