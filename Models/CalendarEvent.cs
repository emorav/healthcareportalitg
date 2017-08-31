﻿/* 
 * Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT license.
 * See LICENSE in the project root for license information.
 */

namespace HealthCare.Portal.Models
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Calendar Event object.
    /// </summary>
    public class CalendarEvent
    {
        /// <summary>
        /// Gets or sets the display name of the user.
        /// </summary>
        /// <value>
        /// The display name of the user.
        /// </value>
        public string UserDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the event identifier.
        /// </summary>
        /// <value>
        /// The event identifier.
        /// </value>
        [JsonProperty("id")]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the body preview.
        /// </summary>
        /// <value>
        /// The body preview.
        /// </value>
        [JsonProperty("bodyPreview")]
        public string BodyPreview { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        [JsonProperty("start")]
        public DateEvent StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        [JsonProperty("end")]
        public DateEvent EndDate { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the attendees.
        /// </summary>
        /// <value>
        /// The attendees.
        /// </value>
        [JsonProperty("attendees")]
        public string Attendees { get; set; }

        /// <summary>
        /// Gets or sets the organizer.
        /// </summary>
        /// <value>
        /// The organizer.
        /// </value>
        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        /// <summary>
        /// Gets or sets the web link.
        /// </summary>
        /// <value>
        /// The web link.
        /// </value>
        [JsonProperty("webLink")]
        public string WebLink { get; set; }

        /// <summary>
        /// Gets or sets the name of the patient.
        /// </summary>
        /// <value>
        /// The name of the patient.
        /// </value>
        [JsonProperty("doctorName")]
        public string DoctorName { get; set; }

        /// <summary>
        /// Gets or sets the name of the patient.
        /// </summary>
        /// <value>
        /// The name of the patient.
        /// </value>
        [JsonProperty("patientName")]
        public string PatientName { get; set; }

        /// <summary>
        /// Gets or sets the meeting URL.
        /// </summary>
        /// <value>
        /// The meeting URL.
        /// </value>
        public string MeetingUrl { get; set; }

        /// <summary>
        /// Gets the encrypted doctor URI.
        /// </summary>
        /// <value>
        /// The encrypted doctor URI.
        /// </value>
        public string EncryptedDoctorUri
        {
            get
            {
                var parameters = MeetingUrl.Split('?')[1] + "&userType=Doctor&displayName=" + DoctorName ?? "Admin";
                return HealthCare.Portal.HelperClasses.EncryptionHelper.Encrypt(parameters);
            }
        }


        /// <summary>
        /// Gets the encrypted patient URI.
        /// </summary>
        /// <value>
        /// The encrypted patient URI.
        /// </value>
        public string EncryptedPatientUri
        {
            get
            {
                var parameters = MeetingUrl.Split('?')[1] + "&userType=Patient&displayName=" + PatientName ?? "Cloud";
                return HealthCare.Portal.HelperClasses.EncryptionHelper.Encrypt(parameters);
            }
        }

        /// <summary>
        /// Gets the encrypted meeting.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public string GetEncryptedMeeting(string parameters)
        {
            return HealthCare.Portal.HelperClasses.EncryptionHelper.Encrypt(parameters);
        }
    }

    /// <summary>
    /// Date Event object.
    /// </summary>
    public class DateEvent
    {
        /// <summary>
        /// Gets or sets the date time value.
        /// </summary>
        /// <value>
        /// The date time value.
        /// </value>
        public DateTime DateTimeValue { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>
        /// The time zone.
        /// </value>
        public string TimeZone { get; set; }
    }

    /// <summary>
    /// Checkbox Item class
    /// </summary>
    public class CheckBoxItem
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the date value.
        /// </summary>
        /// <value>
        /// The date value.
        /// </value>
        public string DateValue { get; set; }

        /// <summary>
        /// Gets or sets the time slot.
        /// </summary>
        /// <value>
        /// The time slot.
        /// </value>
        public string TimeSlot { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is available.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is available; otherwise, <c>false</c>.
        /// </value>
        public bool IsAvailable { get; set; }
    }

    /// <summary>
    /// Meeting Details class.
    /// </summary>
    public class MeetingDetails
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the on line meeting identifier.
        /// </summary>
        /// <value>
        /// The on line meeting identifier.
        /// </value>
        public string OnLineMeetingId { get; set; }

        /// <summary>
        /// Gets or sets the online meeting URI.
        /// </summary>
        /// <value>
        /// The online meeting URI.
        /// </value>
        public string OnlineMeetingUri { get; set; }

        /// <summary>
        /// Gets or sets the online meeting URL.
        /// </summary>
        /// <value>
        /// The online meeting URL.
        /// </value>
        public string OnlineMeetingUrl { get; set; }

        /// <summary>
        /// Gets or sets the organizer.
        /// </summary>
        /// <value>
        /// The organizer.
        /// </value>
        public string Organizer { get; set; }

        /// <summary>
        /// Gets or sets the attendees.
        /// </summary>
        /// <value>
        /// The attendees.
        /// </value>
        public string Attendees { get; set; }

        /// <summary>
        /// Gets or sets the join URL.
        /// </summary>
        /// <value>
        /// The join URL.
        /// </value>
        public string JoinUrl { get; set; }

        /// <summary>
        /// Gets or sets the name of the patient.
        /// </summary>
        /// <value>
        /// The name of the patient.
        /// </value>
        public string PatientName { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the appointment date.
        /// </summary>
        /// <value>
        /// The appointment date.
        /// </value>
        public string AppointmentDate { get; set; }

        /// <summary>
        /// Gets or sets the questionnaire required.
        /// </summary>
        /// <value>
        /// The questionnaire required.
        /// </value>
        public string QuestionnaireRequired { get; set; }

        /// <summary>
        /// Gets or sets the question category.
        /// </summary>
        /// <value>
        /// The question category.
        /// </value>
        public string QuestionCategory { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>
        /// The start time.
        /// </value>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        /// <value>
        /// The end time.
        /// </value>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the name of the doctors.
        /// </summary>
        /// <value>
        /// The name of the doctors.
        /// </value>
        public string DoctorsName { get; set; }
    }

    /// <summary>
    /// User Profile object.
    /// </summary>
    public class UserProfile
    {
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the mail.
        /// </summary>
        /// <value>
        /// The mail.
        /// </value>
        public string Mail { get; set; }

        /// <summary>
        /// Gets or sets the name of the user principal.
        /// </summary>
        /// <value>
        /// The name of the user principal.
        /// </value>
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>
        /// The access token.
        /// </value>
        public string AccessToken { get; set; }
    }
}