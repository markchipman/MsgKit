﻿// ReSharper disable InconsistentNaming

using MsgWriter.Helpers;

namespace MsgWriter
{
    /// <summary>
    ///     Contains all MAPI related constants
    /// </summary>
    internal enum MapiTags : uint
    {
        #region Mapi standard tags
        /*
         *	M A P I T A G S . H
         *
         *	Property tag definitions for standard properties of MAPI
         *	objects.
         *
         *	The following ranges should be used for all property IDs. Note that
         *	property IDs for objects other than messages and recipients should
         *	all fall in the range "3000 to "3FFF:
         *
         *	From	To		Kind of property
         *	--------------------------------
         *	0001	0BFF	MAPI_defined envelope property
         *	0C00	0DFF	MAPI_defined per-recipient property
         *	0E00	0FFF	MAPI_defined non-transmittable property
         *	1000	2FFF	MAPI_defined message content property
         *
         *	3000	3FFF	MAPI_defined property (usually not message or recipient)
         *
         *	4000	57FF	Transport-defined envelope property
         *	5800	5FFF	Transport-defined per-recipient property
         *	6000	65FF	User-defined non-transmittable property
         *	6600	67FF	Provider-defined internal non-transmittable property
         *	6800	7BFF	Message class-defined content property
         *	7C00	7FFF	Message class-defined non-transmittable
         *					property
         *
         *	8000	FFFE	User-defined Name-to-id mapped property
         *
         *	The 3000-3FFF range is further subdivided as follows:
         *
         *	From	To		Kind of property
         *	--------------------------------
         *	3000	33FF	Common property such as display name, entry ID
         *	3400	35FF	Message store object
         *	3600	36FF	Folder or AB container
         *	3700	38FF	Attachment
         *	3900	39FF	Address book object
         *	3A00	3BFF	Mail user
         *	3C00	3CFF	Distribution list
         *	3D00	3DFF	Profile section
         *	3E00	3FFF	Status object
         *
         *  Copyright (c) 2009 Microsoft Corporation. All Rights Reserved.
         */
        [StringValue("0001")]
        PR_ACKNOWLEDGEMENT_MODE = 0x0001,

        [StringValue("0002")]
        PR_ALTERNATE_RECIPIENT_ALLOWED = 0x0002,

        [StringValue("0003")]
        PR_AUTHORIZING_USERS = 0x0003,

        [StringValue("0004")]
        PR_AUTO_FORWARD_COMMENT = 0x0004,

        [StringValue("0004")]
        PR_AUTO_FORWARD_COMMENT_W = 0x0004,

        [StringValue("0004")]
        PR_AUTO_FORWARD_COMMENT_A = 0x0004,

        [StringValue("0005")]
        PR_AUTO_FORWARDED = 0x0005,

        [StringValue("0006")]
        PR_CONTENT_CONFIDENTIALITY_ALGORITHM_ID = 0x0006,

        [StringValue("0007")]
        PR_CONTENT_CORRELATOR = 0x0007,

        [StringValue("0008")]
        PR_CONTENT_IDENTIFIER = 0x0008,

        [StringValue("0008")]
        PR_CONTENT_IDENTIFIER_W = 0x0008,

        [StringValue("0008")]
        PR_CONTENT_IDENTIFIER_A = 0x0008,

        [StringValue("0009")]
        PR_CONTENT_LENGTH = 0x0009,

        [StringValue("000A")]
        PR_CONTENT_RETURN_REQUESTED = 0x000A,

        [StringValue("000B")]
        PR_CONVERSATION_KEY = 0x000B,

        [StringValue("000C")]
        PR_CONVERSION_EITS = 0x000C,

        [StringValue("000D")]
        PR_CONVERSION_WITH_LOSS_PROHIBITED = 0x000D,

        [StringValue("000E")]
        PR_CONVERTED_EITS = 0x000E,

        [StringValue("000F")]
        PR_DEFERRED_DELIVERY_TIME = 0x000F,

        [StringValue("0010")]
        PR_DELIVER_TIME = 0x0010,

        [StringValue("0011")]
        PR_DISCARD_REASON = 0x0011,

        [StringValue("0012")]
        PR_DISCLOSURE_OF_RECIPIENTS = 0x0012,

        [StringValue("0013")]
        PR_DL_EXPANSION_HISTORY = 0x0013,

        [StringValue("0014")]
        PR_DL_EXPANSION_PROHIBITED = 0x0014,

        [StringValue("0015")]
        PR_EXPIRY_TIME = 0x0015,

        [StringValue("0016")]
        PR_IMPLICIT_CONVERSION_PROHIBITED = 0x0016,

        [StringValue("0017")]
        PR_IMPORTANCE = 0x0017,

        [StringValue("0018")]
        PR_IPM_ID = 0x0018,

        [StringValue("0019")]
        PR_LATEST_DELIVERY_TIME = 0x0019,

        [StringValue("001A")]
        PR_MESSAGE_CLASS = 0x001A,

        [StringValue("001A")]
        PR_MESSAGE_CLASS_W = 0x001A,

        [StringValue("001A")]
        PR_MESSAGE_CLASS_A = 0x001A,

        [StringValue("001B")]
        PR_MESSAGE_DELIVERY_ID = 0x001B,

        [StringValue("001E")]
        PR_MESSAGE_SECURITY_LABEL = 0x001E,

        [StringValue("001F")]
        PR_OBSOLETED_IPMS = 0x001F,

        [StringValue("0020")]
        PR_ORIGINALLY_INTENDED_RECIPIENT_NAME = 0x0020,

        [StringValue("0021")]
        PR_ORIGINAL_EITS = 0x0021,

        [StringValue("0022")]
        PR_ORIGINATOR_CERTIFICATE = 0x0022,

        [StringValue("0023")]
        PR_ORIGINATOR_DELIVERY_REPORT_REQUESTED = 0x0023,

        [StringValue("0024")]
        PR_ORIGINATOR_RETURN_ADDRESS = 0x0024,

        [StringValue("0025")]
        PR_PARENT_KEY = 0x0025,

        [StringValue("0026")]
        PR_PRIORITY = 0x0026,

        [StringValue("0027")]
        PR_ORIGIN_CHECK = 0x0027,

        [StringValue("0028")]
        PR_PROOF_OF_SUBMISSION_REQUESTED = 0x0028,

        [StringValue("0029")]
        PR_READ_RECEIPT_REQUESTED = 0x0029,

        [StringValue("002A")]
        PR_RECEIPT_TIME = 0x002A,

        [StringValue("002B")]
        PR_RECIPIENT_REASSIGNMENT_PROHIBITED = 0x002B,

        [StringValue("002C")]
        PR_REDIRECTION_HISTORY = 0x002C,

        [StringValue("002D")]
        PR_RELATED_IPMS = 0x002D,

        [StringValue("002E")]
        PR_ORIGINAL_SENSITIVITY = 0x002E,

        [StringValue("002F")]
        PR_LANGUAGES = 0x002F,

        [StringValue("002F")]
        PR_LANGUAGES_W = 0x002F,

        [StringValue("002F")]
        PR_LANGUAGES_A = 0x002F,

        [StringValue("0030")]
        PR_REPLY_TIME = 0x0030,

        [StringValue("0031")]
        PR_REPORT_TAG = 0x0031,

        [StringValue("0032")]
        PR_REPORT_TIME = 0x0032,

        [StringValue("0033")]
        PR_RETURNED_IPM = 0x0033,

        [StringValue("0034")]
        PR_SECURITY = 0x0034,

        [StringValue("0035")]
        PR_INCOMPLETE_COPY = 0x0035,

        [StringValue("0036")]
        PR_SENSITIVITY = 0x0036,

        [StringValue("0037")]
        PR_SUBJECT = 0x0037,

        [StringValue("0037")]
        PR_SUBJECT_W = 0x0037,

        [StringValue("0037")]
        PR_SUBJECT_A = 0x0037,

        [StringValue("0038")]
        PR_SUBJECT_IPM = 0x0038,

        [StringValue("0039")]
        PR_CLIENT_SUBMIT_TIME = 0x0039,

        [StringValue("003A")]
        PR_REPORT_NAME = 0x003A,

        [StringValue("003A")]
        PR_REPORT_NAME_W = 0x003A,

        [StringValue("003A")]
        PR_REPORT_NAME_A = 0x003A,

        [StringValue("003B")]
        PR_SENT_REPRESENTING_SEARCH_KEY = 0x003B,

        [StringValue("003C")]
        PR_X400_CONTENT_TYPE = 0x003C,

        [StringValue("003D")]
        PR_SUBJECT_PREFIX = 0x003D,

        [StringValue("003D")]
        PR_SUBJECT_PREFIX_W = 0x003D,

        [StringValue("003D")]
        PR_SUBJECT_PREFIX_A = 0x003D,

        [StringValue("003E")]
        PR_NON_RECEIPT_REASON = 0x003E,

        [StringValue("003F")]
        PR_RECEIVED_BY_ENTRYID = 0x003F,

        [StringValue("0040")]
        PR_RECEIVED_BY_NAME = 0x0040,

        [StringValue("0040")]
        PR_RECEIVED_BY_NAME_W = 0x0040,

        [StringValue("0040")]
        PR_RECEIVED_BY_NAME_A = 0x0040,

        [StringValue("0041")]
        PR_SENT_REPRESENTING_ENTRYID = 0x0041,

        [StringValue("0042")]
        PR_SENT_REPRESENTING_NAME = 0x0042,

        [StringValue("0042")]
        PR_SENT_REPRESENTING_NAME_W = 0x0042,

        [StringValue("0042")]
        PR_SENT_REPRESENTING_NAME_A = 0x0042,

        [StringValue("0043")]
        PR_RCVD_REPRESENTING_ENTRYID = 0x0043,

        [StringValue("0044")]
        PR_RCVD_REPRESENTING_NAME = 0x0044,

        [StringValue("0044")]
        PR_RCVD_REPRESENTING_NAME_W = 0x0044,

        [StringValue("0044")]
        PR_RCVD_REPRESENTING_NAME_A = 0x0044,

        [StringValue("0045")]
        PR_REPORT_ENTRYID = 0x0045,

        [StringValue("0046")]
        PR_READ_RECEIPT_ENTRYID = 0x0046,

        [StringValue("0047")]
        PR_MESSAGE_SUBMISSION_ID = 0x0047,

        [StringValue("0048")]
        PR_PROVIDER_SUBMIT_TIME = 0x0048,

        [StringValue("0049")]
        PR_ORIGINAL_SUBJECT = 0x0049,

        [StringValue("0049")]
        PR_ORIGINAL_SUBJECT_W = 0x0049,

        [StringValue("0049")]
        PR_ORIGINAL_SUBJECT_A = 0x0049,

        [StringValue("004A")]
        PR_DISC_VAL = 0x004A,

        [StringValue("004B")]
        PR_ORIG_MESSAGE_CLASS = 0x004B,

        [StringValue("004B")]
        PR_ORIG_MESSAGE_CLASS_W = 0x004B,

        [StringValue("004B")]
        PR_ORIG_MESSAGE_CLASS_A = 0x004B,

        [StringValue("004C")]
        PR_ORIGINAL_AUTHOR_ENTRYID = 0x004C,

        [StringValue("004D")]
        PR_ORIGINAL_AUTHOR_NAME = 0x004D,

        [StringValue("004D")]
        PR_ORIGINAL_AUTHOR_NAME_W = 0x004D,

        [StringValue("004D")]
        PR_ORIGINAL_AUTHOR_NAME_A = 0x004D,

        [StringValue("004E")]
        PR_ORIGINAL_SUBMIT_TIME = 0x004E,

        [StringValue("004F")]
        PR_REPLY_RECIPIENT_ENTRIES = 0x004F,

        [StringValue("0050")]
        PR_REPLY_RECIPIENT_NAMES = 0x0050,

        [StringValue("0050")]
        PR_REPLY_RECIPIENT_NAMES_W = 0x0050,

        [StringValue("0050")]
        PR_REPLY_RECIPIENT_NAMES_A = 0x0050,

        [StringValue("0051")]
        PR_RECEIVED_BY_SEARCH_KEY = 0x0051,

        [StringValue("0052")]
        PR_RCVD_REPRESENTING_SEARCH_KEY = 0x0052,

        [StringValue("0053")]
        PR_READ_RECEIPT_SEARCH_KEY = 0x0053,

        [StringValue("0054")]
        PR_REPORT_SEARCH_KEY = 0x0054,

        [StringValue("0055")]
        PR_ORIGINAL_DELIVERY_TIME = 0x0055,

        [StringValue("0056")]
        PR_ORIGINAL_AUTHOR_SEARCH_KEY = 0x0056,

        [StringValue("0057")]
        PR_MESSAGE_TO_ME = 0x0057,

        [StringValue("0058")]
        PR_MESSAGE_CC_ME = 0x0058,

        [StringValue("0059")]
        PR_MESSAGE_RECIP_ME = 0x0059,

        [StringValue("005A")]
        PR_ORIGINAL_SENDER_NAME = 0x005A,

        [StringValue("005A")]
        PR_ORIGINAL_SENDER_NAME_W = 0x005A,

        [StringValue("005A")]
        PR_ORIGINAL_SENDER_NAME_A = 0x005A,

        [StringValue("005B")]
        PR_ORIGINAL_SENDER_ENTRYID = 0x005B,

        [StringValue("005C")]
        PR_ORIGINAL_SENDER_SEARCH_KEY = 0x005C,

        [StringValue("005D")]
        PR_ORIGINAL_SENT_REPRESENTING_NAME = 0x005D,

        [StringValue("005D")]
        PR_ORIGINAL_SENT_REPRESENTING_NAME_W = 0x005D,

        [StringValue("005D")]
        PR_ORIGINAL_SENT_REPRESENTING_NAME_A = 0x005D,

        [StringValue("005E")]
        PR_ORIGINAL_SENT_REPRESENTING_ENTRYID = 0x005E,

        [StringValue("005F")]
        PR_ORIGINAL_SENT_REPRESENTING_SEARCH_KEY = 0x005F,

        [StringValue("0060")]
        PR_START_DATE = 0x0060,

        [StringValue("0061")]
        PR_END_DATE = 0x0061,

        [StringValue("0062")]
        PR_OWNER_APPT_ID = 0x0062,

        [StringValue("0063")]
        PR_RESPONSE_REQUESTED = 0x0063,

        [StringValue("0064")]
        PR_SENT_REPRESENTING_ADDRTYPE = 0x0064,

        [StringValue("0064")]
        PR_SENT_REPRESENTING_ADDRTYPE_W = 0x0064,

        [StringValue("0064")]
        PR_SENT_REPRESENTING_ADDRTYPE_A = 0x0064,

        [StringValue("0065")]
        PR_SENT_REPRESENTING_EMAIL_ADDRESS = 0x0065,

        [StringValue("0065")]
        PR_SENT_REPRESENTING_EMAIL_ADDRESS_W = 0x0065,

        [StringValue("0065")]
        PR_SENT_REPRESENTING_EMAIL_ADDRESS_A = 0x0065,


        [StringValue("0066")]
        PR_ORIGINAL_SENDER_ADDRTYPE = 0x0066,

        [StringValue("0066")]
        PR_ORIGINAL_SENDER_ADDRTYPE_W = 0x0066,

        [StringValue("0066")]
        PR_ORIGINAL_SENDER_ADDRTYPE_A = 0x0066,

        [StringValue("0067")]
        PR_ORIGINAL_SENDER_EMAIL_ADDRESS = 0x0067,

        [StringValue("0067")]
        PR_ORIGINAL_SENDER_EMAIL_ADDRESS_W = 0x0067,

        [StringValue("0067")]
        PR_ORIGINAL_SENDER_EMAIL_ADDRESS_A = 0x0067,

        [StringValue("0068")]
        PR_ORIGINAL_SENT_REPRESENTING_ADDRTYPE = 0x0068,

        [StringValue("0068")]
        PR_ORIGINAL_SENT_REPRESENTING_ADDRTYPE_W = 0x0068,

        [StringValue("0068")]
        PR_ORIGINAL_SENT_REPRESENTING_ADDRTYPE_A = 0x0068,

        [StringValue("0069")]
        PR_ORIGINAL_SENT_REPRESENTING_EMAIL_ADDRESS = 0x0069,

        [StringValue("0069")]
        PR_ORIGINAL_SENT_REPRESENTING_EMAIL_ADDRESS_W = 0x0069,

        [StringValue("0069")]
        PR_ORIGINAL_SENT_REPRESENTING_EMAIL_ADDRESS_A = 0x0069,

        [StringValue("0070")]
        PR_CONVERSATION_TOPIC = 0x0070,

        [StringValue("0070")]
        PR_CONVERSATION_TOPIC_W = 0x0070,

        [StringValue("0070")]
        PR_CONVERSATION_TOPIC_A = 0x0070,

        [StringValue("0071")]
        PR_CONVERSATION_INDEX = 0x0071,


        [StringValue("0072")]
        PR_ORIGINAL_DISPLAY_BCC = 0x0072,

        [StringValue("0072")]
        PR_ORIGINAL_DISPLAY_BCC_W = 0x0072,

        [StringValue("0072")]
        PR_ORIGINAL_DISPLAY_BCC_A = 0x0072,

        [StringValue("0073")]
        PR_ORIGINAL_DISPLAY_CC = 0x0073,

        [StringValue("0073")]
        PR_ORIGINAL_DISPLAY_CC_W = 0x0073,

        [StringValue("0073")]
        PR_ORIGINAL_DISPLAY_CC_A = 0x0073,

        [StringValue("0074")]
        PR_ORIGINAL_DISPLAY_TO = 0x0074,

        [StringValue("0074")]
        PR_ORIGINAL_DISPLAY_TO_W = 0x0074,

        [StringValue("0074")]
        PR_ORIGINAL_DISPLAY_TO_A = 0x0074,


        [StringValue("0075")]
        PR_RECEIVED_BY_ADDRTYPE = 0x0075,

        [StringValue("0075")]
        PR_RECEIVED_BY_ADDRTYPE_W = 0x0075,

        [StringValue("0075")]
        PR_RECEIVED_BY_ADDRTYPE_A = 0x0075,

        [StringValue("0076")]
        PR_RECEIVED_BY_EMAIL_ADDRESS = 0x0076,

        [StringValue("0076")]
        PR_RECEIVED_BY_EMAIL_ADDRESS_W = 0x0076,

        [StringValue("0076")]
        PR_RECEIVED_BY_EMAIL_ADDRESS_A = 0x0076,


        [StringValue("0077")]
        PR_RCVD_REPRESENTING_ADDRTYPE = 0x0077,

        [StringValue("0077")]
        PR_RCVD_REPRESENTING_ADDRTYPE_W = 0x0077,

        [StringValue("0077")]
        PR_RCVD_REPRESENTING_ADDRTYPE_A = 0x0077,

        [StringValue("0078")]
        PR_RCVD_REPRESENTING_EMAIL_ADDRESS = 0x0078,

        [StringValue("0078")]
        PR_RCVD_REPRESENTING_EMAIL_ADDRESS_W = 0x0078,

        [StringValue("0078")]
        PR_RCVD_REPRESENTING_EMAIL_ADDRESS_A = 0x0078,

        [StringValue("0079")]
        PR_ORIGINAL_AUTHOR_ADDRTYPE = 0x0079,

        [StringValue("0079")]
        PR_ORIGINAL_AUTHOR_ADDRTYPE_W = 0x0079,

        [StringValue("0079")]
        PR_ORIGINAL_AUTHOR_ADDRTYPE_A = 0x0079,

        [StringValue("007A")]
        PR_ORIGINAL_AUTHOR_EMAIL_ADDRESS = 0x007A,

        [StringValue("007A")]
        PR_ORIGINAL_AUTHOR_EMAIL_ADDRESS_W = 0x007A,

        [StringValue("007A")]
        PR_ORIGINAL_AUTHOR_EMAIL_ADDRESS_A = 0x007A,


        [StringValue("007B")]
        PR_ORIGINALLY_INTENDED_RECIP_ADDRTYPE = 0x007B,

        [StringValue("007B")]
        PR_ORIGINALLY_INTENDED_RECIP_ADDRTYPE_W = 0x007B,

        [StringValue("007B")]
        PR_ORIGINALLY_INTENDED_RECIP_ADDRTYPE_A = 0x007B,

        [StringValue("007C")]
        PR_ORIGINALLY_INTENDED_RECIP_EMAIL_ADDRESS = 0x007C,

        [StringValue("007C")]
        PR_ORIGINALLY_INTENDED_RECIP_EMAIL_ADDRESS_W = 0x007C,

        [StringValue("007C")]
        PR_ORIGINALLY_INTENDED_RECIP_EMAIL_ADDRESS_A = 0x007C,


        [StringValue("007D")]
        PR_TRANSPORT_MESSAGE_HEADERS = 0x007D,

        [StringValue("007D")]
        PR_TRANSPORT_MESSAGE_HEADERS_W = 0x007D,

        [StringValue("007D")]
        PR_TRANSPORT_MESSAGE_HEADERS_A = 0x007D,

        [StringValue("007E")]
        PR_DELEGATION = 0x007E,

        [StringValue("007F")]
        PR_TNEF_CORRELATION_KEY = 0x007F,

        /*
         *	Message content properties"
         */

        [StringValue("1000")]
        PR_BODY = 0x1000,

        [StringValue("1000")]
        PR_BODY_W = 0x1000,

        [StringValue("1000")]
        PR_BODY_A = 0x1000,

        [StringValue("1013")]
        PR_BODY_HTML = 0x1013,

        [StringValue("1001")]
        PR_REPORT_TEXT = 0x1001,

        [StringValue("1001")]
        PR_REPORT_TEXT_W = 0x1001,

        [StringValue("1001")]
        PR_REPORT_TEXT_A = 0x1001,

        [StringValue("1002")]
        PR_ORIGINATOR_AND_DL_EXPANSION_HISTORY = 0x1002,

        [StringValue("1003")]
        PR_REPORTING_DL_NAME = 0x1003,

        [StringValue("1004")]
        PR_REPORTING_MTA_CERTIFICATE = 0x1004,


        /*  Removed PR_REPORT_ORIGIN_AUTHENTICATION_CHECK with DCR 3865 =  use PR_ORIGIN_CHECK */


        [StringValue("1006")]
        PR_RTF_SYNC_BODY_CRC = 0x1006,

        [StringValue("1007")]
        PR_RTF_SYNC_BODY_COUNT = 0x1007,

        [StringValue("1008")]
        PR_RTF_SYNC_BODY_TAG = 0x1008,

        [StringValue("1008")]
        PR_RTF_SYNC_BODY_TAG_W = 0x1008,

        [StringValue("1008")]
        PR_RTF_SYNC_BODY_TAG_A = 0x1008,

        [StringValue("1009")]
        PR_RTF_COMPRESSED = 0x1009,

        [StringValue("1010")]
        PR_RTF_SYNC_PREFIX_COUNT = 0x1010,

        [StringValue("1011")]
        PR_RTF_SYNC_TRAILING_COUNT = 0x1011,

        [StringValue("1012")]
        PR_ORIGINALLY_INTENDED_RECIP_ENTRYID = 0x1012,


        /*
        *  Mailing list
        */

        [StringValue("1043")]
        PR_LIST_HELP = 0x1043,

        [StringValue("1044")]
        PR_LIST_SUBSCRIBE = 0x1044,

        [StringValue("1045")]
        PR_LIST_UNSUBSCRIBE = 0x1045,


        /*
         *  Reserved "1100-"1200
         */


        /*
         *	Message recipient properties"
         */

        [StringValue("0C00")]
        PR_CONTENT_INTEGRITY_CHECK = 0x0C00,

        [StringValue("0C01")]
        PR_EXPLICIT_CONVERSION = 0x0C01,

        [StringValue("0C02")]
        PR_IPM_RETURN_REQUESTED = 0x0C02,

        [StringValue("0C03")]
        PR_MESSAGE_TOKEN = 0x0C03,

        [StringValue("0C04")]
        PR_NDR_REASON_CODE = 0x0C04,

        [StringValue("0C05")]
        PR_NDR_DIAG_CODE = 0x0C05,

        [StringValue("0C06")]
        PR_NON_RECEIPT_NOTIFICATION_REQUESTED = 0x0C06,

        [StringValue("0C07")]
        PR_DELIVERY_POINT = 0x0C07,


        [StringValue("0C08")]
        PR_ORIGINATOR_NON_DELIVERY_REPORT_REQUESTED = 0x0C08,

        [StringValue("0C09")]
        PR_ORIGINATOR_REQUESTED_ALTERNATE_RECIPIENT = 0x0C09,

        [StringValue("0C0A")]
        PR_PHYSICAL_DELIVERY_BUREAU_FAX_DELIVERY = 0x0C0A,

        [StringValue("0C0B")]
        PR_PHYSICAL_DELIVERY_MODE = 0x0C0B,

        [StringValue("0C0C")]
        PR_PHYSICAL_DELIVERY_REPORT_REQUEST = 0x0C0C,

        [StringValue("0C0D")]
        PR_PHYSICAL_FORWARDING_ADDRESS = 0x0C0D,

        [StringValue("0C0E")]
        PR_PHYSICAL_FORWARDING_ADDRESS_REQUESTED = 0x0C0E,

        [StringValue("0C0F")]
        PR_PHYSICAL_FORWARDING_PROHIBITED = 0x0C0F,

        [StringValue("0C10")]
        PR_PHYSICAL_RENDITION_ATTRIBUTES = 0x0C10,

        [StringValue("0C11")]
        PR_PROOF_OF_DELIVERY = 0x0C11,

        [StringValue("0C12")]
        PR_PROOF_OF_DELIVERY_REQUESTED = 0x0C12,

        [StringValue("0C13")]
        PR_RECIPIENT_CERTIFICATE = 0x0C13,

        [StringValue("0C14")]
        PR_RECIPIENT_NUMBER_FOR_ADVICE = 0x0C14,

        [StringValue("0C14")]
        PR_RECIPIENT_NUMBER_FOR_ADVICE_W = 0x0C14,

        [StringValue("0C14")]
        PR_RECIPIENT_NUMBER_FOR_ADVICE_A = 0x0C14,

        [StringValue("0C15")]
        PR_RECIPIENT_TYPE = 0x0C15,

        [StringValue("0C16")]
        PR_REGISTERED_MAIL_TYPE = 0x0C16,

        [StringValue("0C17")]
        PR_REPLY_REQUESTED = 0x0C17,

        [StringValue("0C18")]
        PR_REQUESTED_DELIVERY_METHOD = 0x0C18,

        [StringValue("0C19")]
        PR_SENDER_ENTRYID = 0x0C19,

        [StringValue("0C1A")]
        PR_SENDER_NAME = 0x0C1A,

        [StringValue("0C1A")]
        PR_SENDER_NAME_W = 0x0C1A,

        [StringValue("0C1A")]
        PR_SENDER_NAME_A = 0x0C1A,

        [StringValue("0C1B")]
        PR_SUPPLEMENTARY_INFO = 0x0C1B,

        [StringValue("0C1B")]
        PR_SUPPLEMENTARY_INFO_W = 0x0C1B,

        [StringValue("0C1B")]
        PR_SUPPLEMENTARY_INFO_A = 0x0C1B,

        [StringValue("0C1C")]
        PR_TYPE_OF_MTS_USER = 0x0C1C,

        [StringValue("0C1D")]
        PR_SENDER_SEARCH_KEY = 0x0C1D,

        [StringValue("0C1E")]
        PR_SENDER_ADDRTYPE = 0x0C1E,

        [StringValue("0C1E")]
        PR_SENDER_ADDRTYPE_W = 0x0C1E,

        [StringValue("0C1E")]
        PR_SENDER_ADDRTYPE_A = 0x0C1E,

        [StringValue("0C1F")]
        PR_SENDER_EMAIL_ADDRESS = 0x0C1F,

        [StringValue("0C1F")]
        PR_SENDER_EMAIL_ADDRESS_W = 0x0C1F,

        [StringValue("0C1F")]
        PR_SENDER_EMAIL_ADDRESS_A = 0x0C1F,


        /*
         *	Message non-transmittable properties"
         */

        /*
         * The two tags =  PR_MESSAGE_RECIPIENTS and PR_MESSAGE_ATTACHMENTS,

         * are to be used in the exclude list passed to
         * IMessage::CopyTo when the caller wants either the recipients or attachments
         * of the message to not get copied.  It is also used in the ProblemArray
         * return from IMessage::CopyTo when an error is encountered copying them
         */

        [StringValue("0E00")]
        PR_CURRENT_VERSION = 0x0E00,

        [StringValue("0E01")]
        PR_DELETE_AFTER_SUBMIT = 0x0E01,

        [StringValue("0E02")]
        PR_DISPLAY_BCC = 0x0E02,

        [StringValue("0E02")]
        PR_DISPLAY_BCC_W = 0x0E02,

        [StringValue("0E02")]
        PR_DISPLAY_BCC_A = 0x0E02,

        [StringValue("0E03")]
        PR_DISPLAY_CC = 0x0E03,

        [StringValue("0E03")]
        PR_DISPLAY_CC_W = 0x0E03,

        [StringValue("0E03")]
        PR_DISPLAY_CC_A = 0x0E03,

        [StringValue("0E04")]
        PR_DISPLAY_TO = 0x0E04,

        [StringValue("0E04")]
        PR_DISPLAY_TO_W = 0x0E04,

        [StringValue("0E04")]
        PR_DISPLAY_TO_A = 0x0E04,

        [StringValue("0E05")]
        PR_PARENT_DISPLAY = 0x0E05,

        [StringValue("0E05")]
        PR_PARENT_DISPLAY_W = 0x0E05,

        [StringValue("0E05")]
        PR_PARENT_DISPLAY_A = 0x0E05,

        [StringValue("0E06")]
        PR_MESSAGE_DELIVERY_TIME = 0x0E06,

        [StringValue("0E07")]
        PR_MESSAGE_FLAGS = 0x0E07,

        [StringValue("0E08")]
        PR_MESSAGE_SIZE = 0x0E08,

        [StringValue("0E09")]
        PR_PARENT_ENTRYID = 0x0E09,

        [StringValue("0E0A")]
        PR_SENTMAIL_ENTRYID = 0x0E0A,

        [StringValue("0E0C")]
        PR_CORRELATE = 0x0E0C,

        [StringValue("0E0D")]
        PR_CORRELATE_MTSID = 0x0E0D,

        [StringValue("0E0E")]
        PR_DISCRETE_VALUES = 0x0E0E,

        [StringValue("0E0F")]
        PR_RESPONSIBILITY = 0x0E0F,

        [StringValue("0E10")]
        PR_SPOOLER_STATUS = 0x0E10,

        [StringValue("0E11")]
        PR_TRANSPORT_STATUS = 0x0E11,

        [StringValue("0E12")]
        PR_MESSAGE_RECIPIENTS = 0x0E12,

        [StringValue("0E13")]
        PR_MESSAGE_ATTACHMENTS = 0x0E13,

        [StringValue("0E14")]
        PR_SUBMIT_FLAGS = 0x0E14,

        [StringValue("0E15")]
        PR_RECIPIENT_STATUS = 0x0E15,

        [StringValue("0E16")]
        PR_TRANSPORT_KEY = 0x0E16,

        [StringValue("0E17")]
        PR_MSG_STATUS = 0x0E17,

        [StringValue("0E18")]
        PR_MESSAGE_DOWNLOAD_TIME = 0x0E18,

        [StringValue("0E19")]
        PR_CREATION_VERSION = 0x0E19,

        [StringValue("0E1A")]
        PR_MODIFY_VERSION = 0x0E1A,

        [StringValue("0E1B")]
        PR_HASATTACH = 0x0E1B,

        [StringValue("0E1C")]
        PR_BODY_CRC = 0x0E1C,

        [StringValue("0E1D")]
        PR_NORMALIZED_SUBJECT = 0x0E1D,

        [StringValue("0E1D")]
        PR_NORMALIZED_SUBJECT_W = 0x0E1D,

        [StringValue("0E1D")]
        PR_NORMALIZED_SUBJECT_A = 0x0E1D,

        [StringValue("0E1F")]
        PR_RTF_IN_SYNC = 0x0E1F,

        [StringValue("0E20")]
        PR_ATTACH_SIZE = 0x0E20,

        [StringValue("0E21")]
        PR_ATTACH_NUM = 0x0E21,

        [StringValue("0E22")]
        PR_PREPROCESS = 0x0E22,

        [StringValue("0E25")]
        PR_ORIGINATING_MTA_CERTIFICATE = 0x0E25,

        [StringValue("0E26")]
        PR_PROOF_OF_SUBMISSION = 0x0E26,
        
        /*
         * The range of non-message and non-recipient property IDs ("3000 - "3FFF") is
         * further broken down into ranges to make assigning new property IDs easier.
         *
         *	From	To		Kind of property
         *	--------------------------------
         *	3000	32FF	MAPI_defined common property
         *	3200	33FF	MAPI_defined form property
         *	3400	35FF	MAPI_defined message store property
         *	3600	36FF	MAPI_defined Folder or AB Container property
         *	3700	38FF	MAPI_defined attachment property
         *	3900	39FF	MAPI_defined address book property
         *	3A00	3BFF	MAPI_defined mailuser property
         *	3C00	3CFF	MAPI_defined DistList property
         *	3D00	3DFF	MAPI_defined Profile Section property
         *	3E00	3EFF	MAPI_defined Status property
         *	3F00	3FFF	MAPI_defined display table property
        */

        /*
         *	Properties common to numerous MAPI objects.
         *
         *	Those properties that can appear on messages are in the
         *	non-transmittable range for messages. They start at the high
         *	end of that range and work down.
         *
         *	Properties that never appear on messages are defined in the common
         *	property range (see above)
         */

        /*
         * properties that are common to multiple objects (including message objects
         * -- these ids are in the non-transmittable range
         */

        [StringValue("0FFF")]
        PR_ENTRYID = 0x0FFF,

        [StringValue("0FFE")]
        PR_OBJECT_TYPE = 0x0FFE,

        [StringValue("0FFD")]
        PR_ICON = 0x0FFD,

        [StringValue("0FFC")]
        PR_MINI_ICON = 0x0FFC,

        [StringValue("0FFB")]
        PR_STORE_ENTRYID = 0x0FFB,

        [StringValue("0FFA")]
        PR_STORE_RECORD_KEY = 0x0FFA,

        [StringValue("0FF9")]
        PR_RECORD_KEY = 0x0FF9,

        [StringValue("0FF8")]
        PR_MAPPING_SIGNATURE = 0x0FF8,

        [StringValue("0FF7")]
        PR_ACCESS_LEVEL = 0x0FF7,

        [StringValue("0FF6")]
        PR_INSTANCE_KEY = 0x0FF6,

        [StringValue("0FF5")]
        PR_ROW_TYPE = 0x0FF5,

        [StringValue("0FF4")]
        PR_ACCESS = 0x0FF4,

        /*
         * properties that are common to multiple objects (usually not including message objects
         * -- these ids are in the transmittable range
         */

        [StringValue("3000")]
        PR_ROWID = 0x3000,

        [StringValue("3001")]
        PR_DISPLAY_NAME = 0x3001,

        [StringValue("3001")]
        PR_DISPLAY_NAME_W = 0x3001,

        [StringValue("3001")]
        PR_DISPLAY_NAME_A = 0x3001,

        [StringValue("3002")]
        PR_ADDRTYPE = 0x3002,

        [StringValue("3002")]
        PR_ADDRTYPE_W = 0x3002,

        [StringValue("3002")]
        PR_ADDRTYPE_A = 0x3002,

        [StringValue("3003")]
        PR_EMAIL_ADDRESS = 0x3003,

        [StringValue("3003")]
        PR_EMAIL_ADDRESS_W = 0x3003,

        [StringValue("3003")]
        PR_EMAIL_ADDRESS_A = 0x3003,

        [StringValue("3004")]
        PR_COMMENT = 0x3004,

        [StringValue("3004")]
        PR_COMMENT_W = 0x3004,

        [StringValue("3004")]
        PR_COMMENT_A = 0x3004,

        [StringValue("3005")]
        PR_DEPTH = 0x3005,

        [StringValue("3006")]
        PR_PROVIDER_DISPLAY = 0x3006,

        [StringValue("3006")]
        PR_PROVIDER_DISPLAY_W = 0x3006,

        [StringValue("3006")]
        PR_PROVIDER_DISPLAY_A = 0x3006,

        [StringValue("3007")]
        PR_CREATION_TIME = 0x3007,

        [StringValue("3008")]
        PR_LAST_MODIFICATION_TIME = 0x3008,

        [StringValue("3009")]
        PR_RESOURCE_FLAGS = 0x3009,

        [StringValue("300A")]
        PR_PROVIDER_DLL_NAME = 0x300A,

        [StringValue("300A")]
        PR_PROVIDER_DLL_NAME_W = 0x300A,

        [StringValue("300A")]
        PR_PROVIDER_DLL_NAME_A = 0x300A,

        [StringValue("300B")]
        PR_SEARCH_KEY = 0x300B,

        [StringValue("300C")]
        PR_PROVIDER_UID = 0x300C,

        [StringValue("300D")]
        PR_PROVIDER_ORDINAL = 0x300D,
        
        /*
         *  MAPI Form properties
         */
        [StringValue("3301")]
        PR_FORM_VERSION = 0x3301,

        [StringValue("3301")]
        PR_FORM_VERSION_W = 0x3301,

        [StringValue("3301")]
        PR_FORM_VERSION_A = 0x3301,

        [StringValue("3302")]
        PR_FORM_CLSID = 0x3302,

        [StringValue("3303")]
        PR_FORM_CONTACT_NAME = 0x3303,

        [StringValue("3303")]
        PR_FORM_CONTACT_NAME_W = 0x3303,

        [StringValue("3303")]
        PR_FORM_CONTACT_NAME_A = 0x3303,

        [StringValue("3304")]
        PR_FORM_CATEGORY = 0x3304,

        [StringValue("3304")]
        PR_FORM_CATEGORY_W = 0x3304,

        [StringValue("3304")]
        PR_FORM_CATEGORY_A = 0x3304,

        [StringValue("3305")]
        PR_FORM_CATEGORY_SUB = 0x3305,

        [StringValue("3305")]
        PR_FORM_CATEGORY_SUB_W = 0x3305,

        [StringValue("3305")]
        PR_FORM_CATEGORY_SUB_A = 0x3305,

        [StringValue("3306")]
        PR_FORM_HOST_MAP = 0x3306,

        [StringValue("3307")]
        PR_FORM_HIDDEN = 0x3307,

        [StringValue("3308")]
        PR_FORM_DESIGNER_NAME = 0x3308,

        [StringValue("3308")]
        PR_FORM_DESIGNER_NAME_W = 0x3308,

        [StringValue("3308")]
        PR_FORM_DESIGNER_NAME_A = 0x3308,

        [StringValue("3309")]
        PR_FORM_DESIGNER_GUID = 0x3309,

        [StringValue("330A")]
        PR_FORM_MESSAGE_BEHAVIOR = 0x330A,
        
        /*
         *	Message store properties"
         */

        [StringValue("3400")]
        PR_DEFAULT_STORE = 0x3400,

        [StringValue("340D")]
        PR_STORE_SUPPORT_MASK = 0x340D,

        [StringValue("340E")]
        PR_STORE_STATE = 0x340E,
        
        [StringValue("3410")]
        PR_IPM_SUBTREE_SEARCH_KEY = 0x3410,

        [StringValue("3411")]
        PR_IPM_OUTBOX_SEARCH_KEY = 0x3411,

        [StringValue("3412")]
        PR_IPM_WASTEBASKET_SEARCH_KEY = 0x3412,

        [StringValue("3413")]
        PR_IPM_SENTMAIL_SEARCH_KEY = 0x3413,

        [StringValue("3414")]
        PR_MDB_PROVIDER = 0x3414,

        [StringValue("3415")]
        PR_RECEIVE_FOLDER_SETTINGS = 0x3415,

        [StringValue("35DF")]
        PR_VALID_FOLDER_MASK = 0x35DF,

        [StringValue("35E0")]
        PR_IPM_SUBTREE_ENTRYID = 0x35E0,

        [StringValue("35E2")]
        PR_IPM_OUTBOX_ENTRYID = 0x35E2,

        [StringValue("35E3")]
        PR_IPM_WASTEBASKET_ENTRYID = 0x35E3,

        [StringValue("35E4")]
        PR_IPM_SENTMAIL_ENTRYID = 0x35E4,

        [StringValue("35E5")]
        PR_VIEWS_ENTRYID = 0x35E5,

        [StringValue("35E6")]
        PR_COMMON_VIEWS_ENTRYID = 0x35E6,

        [StringValue("35E7")]
        PR_FINDER_ENTRYID = 0x35E7,
        
        /* Proptags "35E8-"35FF reserved for folders "guaranteed" by PR_VALID_FOLDER_MASK */
        /*
         *	Folder and AB Container properties"
         */

        [StringValue("3600")]
        PR_CONTAINER_FLAGS = 0x3600,

        [StringValue("3601")]
        PR_FOLDER_TYPE = 0x3601,

        [StringValue("3602")]
        PR_CONTENT_COUNT = 0x3602,

        [StringValue("3603")]
        PR_CONTENT_UNREAD = 0x3603,

        [StringValue("3604")]
        PR_CREATE_TEMPLATES = 0x3604,

        [StringValue("3605")]
        PR_DETAILS_TABLE = 0x3605,

        [StringValue("3607")]
        PR_SEARCH = 0x3607,

        [StringValue("3609")]
        PR_SELECTABLE = 0x3609,

        [StringValue("360A")]
        PR_SUBFOLDERS = 0x360A,

        [StringValue("360B")]
        PR_STATUS = 0x360B,

        [StringValue("360C")]
        PR_ANR = 0x360C,

        [StringValue("360C")]
        PR_ANR_W = 0x360C,

        [StringValue("360C")]
        PR_ANR_A = 0x360C,

        [StringValue("360D")]
        PR_CONTENTS_SORT_ORDER = 0x360D,

        [StringValue("360E")]
        PR_CONTAINER_HIERARCHY = 0x360E,

        [StringValue("360F")]
        PR_CONTAINER_CONTENTS = 0x360F,

        [StringValue("3610")]
        PR_FOLDER_ASSOCIATED_CONTENTS = 0x3610,

        [StringValue("3611")]
        PR_DEF_CREATE_DL = 0x3611,

        [StringValue("3612")]
        PR_DEF_CREATE_MAILUSER = 0x3612,

        [StringValue("3613")]
        PR_CONTAINER_CLASS = 0x3613,

        [StringValue("3613")]
        PR_CONTAINER_CLASS_W = 0x3613,

        [StringValue("3613")]
        PR_CONTAINER_CLASS_A = 0x3613,

        [StringValue("3614")]
        PR_CONTAINER_MODIFY_VERSION = 0x3614,

        [StringValue("3615")]
        PR_AB_PROVIDER_ID = 0x3615,

        [StringValue("3616")]
        PR_DEFAULT_VIEW_ENTRYID = 0x3616,

        [StringValue("3617")]
        PR_ASSOC_CONTENT_COUNT = 0x3617,
        
        /* Reserved "36C0-"36FF */
        /*
         *	Attachment properties"
         */

        [StringValue("3700")]
        PR_ATTACHMENT_X400_PARAMETERS = 0x3700,

        [StringValue("3701")]
        PR_ATTACH_DATA_OBJ = 0x3701,

        [StringValue("3701")]
        PR_ATTACH_DATA_BIN = 0x3701,

        [StringValue("3702")]
        PR_ATTACH_ENCODING = 0x3702,

        [StringValue("3703")]
        PR_ATTACH_EXTENSION = 0x3703,

        [StringValue("3703")]
        PR_ATTACH_EXTENSION_W = 0x3703,

        [StringValue("3703")]
        PR_ATTACH_EXTENSION_A = 0x3703,

        [StringValue("3704")]
        PR_ATTACH_FILENAME = 0x3704,

        [StringValue("3704")]
        PR_ATTACH_FILENAME_W = 0x3704,

        [StringValue("3704")]
        PR_ATTACH_FILENAME_A = 0x3704,

        [StringValue("3705")]
        PR_ATTACH_METHOD = 0x3705,

        [StringValue("3707")]
        PR_ATTACH_LONG_FILENAME = 0x3707,

        [StringValue("3707")]
        PR_ATTACH_LONG_FILENAME_W = 0x3707,

        [StringValue("3707")]
        PR_ATTACH_LONG_FILENAME_A = 0x3707,

        [StringValue("3708")]
        PR_ATTACH_PATHNAME = 0x3708,

        [StringValue("3708")]
        PR_ATTACH_PATHNAME_W = 0x3708,

        [StringValue("3708")]
        PR_ATTACH_PATHNAME_A = 0x3708,

        [StringValue("3709")]
        PR_ATTACH_RENDERING = 0x3709,

        [StringValue("3712")]
        PR_ATTACH_CONTENTID = 0x3712,

        [StringValue("370A")]
        PR_ATTACH_TAG = 0x370A,

        [StringValue("370B")]
        PR_RENDERING_POSITION = 0x370B,

        [StringValue("370C")]
        PR_ATTACH_TRANSPORT_NAME = 0x370C,

        [StringValue("370C")]
        PR_ATTACH_TRANSPORT_NAME_W = 0x370C,

        [StringValue("370C")]
        PR_ATTACH_TRANSPORT_NAME_A = 0x370C,

        [StringValue("370D")]
        PR_ATTACH_LONG_PATHNAME = 0x370D,

        [StringValue("370D")]
        PR_ATTACH_LONG_PATHNAME_W = 0x370D,

        [StringValue("370D")]
        PR_ATTACH_LONG_PATHNAME_A = 0x370D,

        [StringValue("370E")]
        PR_ATTACH_MIME_TAG = 0x370E,

        [StringValue("370E")]
        PR_ATTACH_MIME_TAG_W = 0x370E,

        [StringValue("370E")]
        PR_ATTACH_MIME_TAG_A = 0x370E,

        [StringValue("370F")]
        PR_ATTACH_ADDITIONAL_INFO = 0x370F,

        [StringValue("7FFF")]
        PR_ATTACHMENT_CONTACTPHOTO = 0x7FFF,

        /*
         *  AB Object properties
         */

        [StringValue("3900")]
        PR_DISPLAY_TYPE = 0x3900,

        [StringValue("3905")]
        PR_DISPLAY_TYPE_EX = 0x3905,

        [StringValue("3902")]
        PR_TEMPLATEID = 0x3902,

        [StringValue("3904")]
        PR_PRIMARY_CAPABILITY = 0x3904,

        /*
         *	Mail user properties"
         */

        [StringValue("39FF")]
        PR_7BIT_DISPLAY_NAME = 0x39FF,

        [StringValue("3A00")]
        PR_ACCOUNT = 0x3A00,

        [StringValue("3A00")]
        PR_ACCOUNT_W = 0x3A00,

        /// <summary>
        /// Contains the SMTP address for the address book object.
        /// </summary>
        [StringValue("39FE")]
        PR_SMTP_ADDRESS = 0x39FE,

        /// <summary>
        /// Second place to search for an E-mail address
        /// </summary>
        [StringValue("403E")]
        PR_ORGEMAILADDR = 0x403E,

        [StringValue("3A00")]
        PR_ACCOUNT_A = 0x3A00,

        [StringValue("3A01")]
        PR_ALTERNATE_RECIPIENT = 0x3A01,

        [StringValue("3A02")]
        PR_CALLBACK_TELEPHONE_NUMBER = 0x3A02,

        [StringValue("3A02")]
        PR_CALLBACK_TELEPHONE_NUMBER_W = 0x3A02,

        [StringValue("3A02")]
        PR_CALLBACK_TELEPHONE_NUMBER_A = 0x3A02,

        [StringValue("3A03")]
        PR_CONVERSION_PROHIBITED = 0x3A03,

        [StringValue("3A04")]
        PR_DISCLOSE_RECIPIENTS = 0x3A04,

        [StringValue("3A05")]
        PR_GENERATION = 0x3A05,

        [StringValue("3A05")]
        PR_GENERATION_W = 0x3A05,

        [StringValue("3A05")]
        PR_GENERATION_A = 0x3A05,

        [StringValue("3A06")]
        PR_GIVEN_NAME = 0x3A06,

        [StringValue("3A06")]
        PR_GIVEN_NAME_W = 0x3A06,

        [StringValue("3A06")]
        PR_GIVEN_NAME_A = 0x3A06,

        [StringValue("3A07")]
        PR_GOVERNMENT_ID_NUMBER = 0x3A07,

        [StringValue("3A07")]
        PR_GOVERNMENT_ID_NUMBER_W = 0x3A07,

        [StringValue("3A07")]
        PR_GOVERNMENT_ID_NUMBER_A = 0x3A07,

        [StringValue("3A08")]
        PR_BUSINESS_TELEPHONE_NUMBER = 0x3A08,

        [StringValue("3A08")]
        PR_BUSINESS_TELEPHONE_NUMBER_W = 0x3A08,

        [StringValue("3A08")]
        PR_BUSINESS_TELEPHONE_NUMBER_A = 0x3A08,

        [StringValue("3A08")]
        PR_OFFICE_TELEPHONE_NUMBER = 0x3A08,

        [StringValue("3A08")]
        PR_OFFICE_TELEPHONE_NUMBER_W = 0x3A08,

        [StringValue("3A08")]
        PR_OFFICE_TELEPHONE_NUMBER_A = 0x3A08,

        [StringValue("3A09")]
        PR_HOME_TELEPHONE_NUMBER = 0x3A09,

        [StringValue("3A09")]
        PR_HOME_TELEPHONE_NUMBER_W = 0x3A09,

        [StringValue("3A09")]
        PR_HOME_TELEPHONE_NUMBER_A = 0x3A09,

        [StringValue("3A0A")]
        PR_INITIALS = 0x3A0A,

        [StringValue("3A0A")]
        PR_INITIALS_W = 0x3A0A,

        [StringValue("3A0A")]
        PR_INITIALS_A = 0x3A0A,

        [StringValue("3A0B")]
        PR_KEYWORD = 0x3A0B,

        [StringValue("3A0B")]
        PR_KEYWORD_W = 0x3A0B,

        [StringValue("3A0B")]
        PR_KEYWORD_A = 0x3A0B,

        [StringValue("3A0C")]
        PR_LANGUAGE = 0x3A0C,

        [StringValue("3A0C")]
        PR_LANGUAGE_W = 0x3A0C,

        [StringValue("3A0C")]
        PR_LANGUAGE_A = 0x3A0C,

        [StringValue("3A0D")]
        PR_LOCATION = 0x3A0D,

        [StringValue("3A0D")]
        PR_LOCATION_W = 0x3A0D,

        [StringValue("3A0D")]
        PR_LOCATION_A = 0x3A0D,

        [StringValue("3A0E")]
        PR_MAIL_PERMISSION = 0x3A0E,

        [StringValue("3A0F")]
        PR_MHS_COMMON_NAME = 0x3A0F,

        [StringValue("3A0F")]
        PR_MHS_COMMON_NAME_W = 0x3A0F,

        [StringValue("3A0F")]
        PR_MHS_COMMON_NAME_A = 0x3A0F,

        [StringValue("3A10")]
        PR_ORGANIZATIONAL_ID_NUMBER = 0x3A10,

        [StringValue("3A10")]
        PR_ORGANIZATIONAL_ID_NUMBER_W = 0x3A10,

        [StringValue("3A10")]
        PR_ORGANIZATIONAL_ID_NUMBER_A = 0x3A10,

        [StringValue("3A11")]
        PR_SURNAME = 0x3A11,

        [StringValue("3A11")]
        PR_SURNAME_W = 0x3A11,

        [StringValue("3A11")]
        PR_SURNAME_A = 0x3A11,

        [StringValue("3A12")]
        PR_ORIGINAL_ENTRYID = 0x3A12,

        [StringValue("3A13")]
        PR_ORIGINAL_DISPLAY_NAME = 0x3A13,

        [StringValue("3A13")]
        PR_ORIGINAL_DISPLAY_NAME_W = 0x3A13,

        [StringValue("3A13")]
        PR_ORIGINAL_DISPLAY_NAME_A = 0x3A13,

        [StringValue("3A14")]
        PR_ORIGINAL_SEARCH_KEY = 0x3A14,

        [StringValue("3A15")]
        PR_POSTAL_ADDRESS = 0x3A15,

        [StringValue("3A15")]
        PR_POSTAL_ADDRESS_W = 0x3A15,

        [StringValue("3A15")]
        PR_POSTAL_ADDRESS_A = 0x3A15,

        [StringValue("3A16")]
        PR_COMPANY_NAME = 0x3A16,

        [StringValue("3A16")]
        PR_COMPANY_NAME_W = 0x3A16,

        [StringValue("3A16")]
        PR_COMPANY_NAME_A = 0x3A16,

        [StringValue("3A17")]
        PR_TITLE = 0x3A17,

        [StringValue("3A17")]
        PR_TITLE_W = 0x3A17,

        [StringValue("3A17")]
        PR_TITLE_A = 0x3A17,

        [StringValue("3A18")]
        PR_DEPARTMENT_NAME = 0x3A18,

        [StringValue("3A18")]
        PR_DEPARTMENT_NAME_W = 0x3A18,

        [StringValue("3A18")]
        PR_DEPARTMENT_NAME_A = 0x3A18,

        [StringValue("3A19")]
        PR_OFFICE_LOCATION = 0x3A19,

        [StringValue("3A19")]
        PR_OFFICE_LOCATION_W = 0x3A19,

        [StringValue("3A19")]
        PR_OFFICE_LOCATION_A = 0x3A19,

        [StringValue("3A1A")]
        PR_PRIMARY_TELEPHONE_NUMBER = 0x3A1A,

        [StringValue("3A1A")]
        PR_PRIMARY_TELEPHONE_NUMBER_W = 0x3A1A,

        [StringValue("3A1A")]
        PR_PRIMARY_TELEPHONE_NUMBER_A = 0x3A1A,

        [StringValue("3A1B")]
        PR_BUSINESS2_TELEPHONE_NUMBER = 0x3A1B,

        [StringValue("3A1B")]
        PR_BUSINESS2_TELEPHONE_NUMBER_W = 0x3A1B,

        [StringValue("3A1B")]
        PR_BUSINESS2_TELEPHONE_NUMBER_A = 0x3A1B,

        [StringValue("3A1B")]
        PR_OFFICE2_TELEPHONE_NUMBER = 0x3A1B,

        [StringValue("3A1B")]
        PR_OFFICE2_TELEPHONE_NUMBER_W = 0x3A1B,

        [StringValue("3A1B")]
        PR_OFFICE2_TELEPHONE_NUMBER_A = 0x3A1B,

        [StringValue("3A1C")]
        PR_MOBILE_TELEPHONE_NUMBER = 0x3A1C,

        [StringValue("3A1C")]
        PR_MOBILE_TELEPHONE_NUMBER_W = 0x3A1C,

        [StringValue("3A1C")]
        PR_MOBILE_TELEPHONE_NUMBER_A = 0x3A1C,

        [StringValue("3A1C")]
        PR_CELLULAR_TELEPHONE_NUMBER = 0x3A1C,

        [StringValue("3A1C")]
        PR_CELLULAR_TELEPHONE_NUMBER_W = 0x3A1C,

        [StringValue("3A1C")]
        PR_CELLULAR_TELEPHONE_NUMBER_A = 0x3A1C,

        [StringValue("3A1D")]
        PR_RADIO_TELEPHONE_NUMBER = 0x3A1D,

        [StringValue("3A1D")]
        PR_RADIO_TELEPHONE_NUMBER_W = 0x3A1D,

        [StringValue("3A1D")]
        PR_RADIO_TELEPHONE_NUMBER_A = 0x3A1D,

        [StringValue("3A1E")]
        PR_CAR_TELEPHONE_NUMBER = 0x3A1E,

        [StringValue("3A1E")]
        PR_CAR_TELEPHONE_NUMBER_W = 0x3A1E,

        [StringValue("3A1E")]
        PR_CAR_TELEPHONE_NUMBER_A = 0x3A1E,

        [StringValue("3A1F")]
        PR_OTHER_TELEPHONE_NUMBER = 0x3A1F,

        [StringValue("3A1F")]
        PR_OTHER_TELEPHONE_NUMBER_W = 0x3A1F,

        [StringValue("3A1F")]
        PR_OTHER_TELEPHONE_NUMBER_A = 0x3A1F,

        [StringValue("3A20")]
        PR_TRANSMITABLE_DISPLAY_NAME = 0x3A20,

        [StringValue("3A20")]
        PR_TRANSMITABLE_DISPLAY_NAME_W = 0x3A20,

        [StringValue("3A20")]
        PR_TRANSMITABLE_DISPLAY_NAME_A = 0x3A20,

        [StringValue("3A21")]
        PR_PAGER_TELEPHONE_NUMBER = 0x3A21,

        [StringValue("3A21")]
        PR_PAGER_TELEPHONE_NUMBER_W = 0x3A21,

        [StringValue("3A21")]
        PR_PAGER_TELEPHONE_NUMBER_A = 0x3A21,

        [StringValue("3A21")]
        PR_BEEPER_TELEPHONE_NUMBER = 0x3A21,

        [StringValue("3A21")]
        PR_BEEPER_TELEPHONE_NUMBER_W = 0x3A21,

        [StringValue("3A21")]
        PR_BEEPER_TELEPHONE_NUMBER_A = 0x3A21,

        [StringValue("3A22")]
        PR_USER_CERTIFICATE = 0x3A22,

        [StringValue("3A23")]
        PR_PRIMARY_FAX_NUMBER = 0x3A23,

        [StringValue("3A23")]
        PR_PRIMARY_FAX_NUMBER_W = 0x3A23,

        [StringValue("3A23")]
        PR_PRIMARY_FAX_NUMBER_A = 0x3A23,

        [StringValue("3A24")]
        PR_BUSINESS_FAX_NUMBER = 0x3A24,

        [StringValue("3A24")]
        PR_BUSINESS_FAX_NUMBER_W = 0x3A24,

        [StringValue("3A24")]
        PR_BUSINESS_FAX_NUMBER_A = 0x3A24,

        [StringValue("3A25")]
        PR_HOME_FAX_NUMBER = 0x3A25,

        [StringValue("3A25")]
        PR_HOME_FAX_NUMBER_W = 0x3A25,

        [StringValue("3A25")]
        PR_HOME_FAX_NUMBER_A = 0x3A25,

        [StringValue("3A26")]
        PR_COUNTRY = 0x3A26,

        [StringValue("3A26")]
        PR_COUNTRY_W = 0x3A26,

        [StringValue("3A26")]
        PR_COUNTRY_A = 0x3A26,

        [StringValue("3A26")]
        PR_BUSINESS_ADDRESS_COUNTRY = 0x3A26,

        [StringValue("3A26")]
        PR_BUSINESS_ADDRESS_COUNTRY_W = 0x3A26,

        [StringValue("3A26")]
        PR_BUSINESS_ADDRESS_COUNTRY_A = 0x3A26,

        [StringValue("3A27")]
        PR_LOCALITY = 0x3A27,

        [StringValue("3A27")]
        PR_LOCALITY_W = 0x3A27,

        [StringValue("3A27")]
        PR_LOCALITY_A = 0x3A27,

        [StringValue("3A27")]
        PR_BUSINESS_ADDRESS_CITY = 0x3A27,

        [StringValue("3A27")]
        PR_BUSINESS_ADDRESS_CITY_W = 0x3A27,

        [StringValue("3A27")]
        PR_BUSINESS_ADDRESS_CITY_A = 0x3A27,

        [StringValue("3A28")]
        PR_STATE_OR_PROVINCE = 0x3A28,

        [StringValue("3A28")]
        PR_STATE_OR_PROVINCE_W = 0x3A28,

        [StringValue("3A28")]
        PR_STATE_OR_PROVINCE_A = 0x3A28,

        [StringValue("3A28")]
        PR_BUSINESS_ADDRESS_STATE_OR_PROVINCE = 0x3A28,

        [StringValue("3A28")]
        PR_BUSINESS_ADDRESS_STATE_OR_PROVINCE_W = 0x3A28,

        [StringValue("3A28")]
        PR_BUSINESS_ADDRESS_STATE_OR_PROVINCE_A = 0x3A28,

        [StringValue("3A29")]
        PR_STREET_ADDRESS = 0x3A29,

        [StringValue("3A29")]
        PR_STREET_ADDRESS_W = 0x3A29,

        [StringValue("3A29")]
        PR_STREET_ADDRESS_A = 0x3A29,

        [StringValue("3A29")]
        PR_BUSINESS_ADDRESS_STREET = 0x3A29,

        [StringValue("3A29")]
        PR_BUSINESS_ADDRESS_STREET_W = 0x3A29,

        [StringValue("3A29")]
        PR_BUSINESS_ADDRESS_STREET_A = 0x3A29,

        [StringValue("3A2A")]
        PR_POSTAL_CODE = 0x3A2A,

        [StringValue("3A2A")]
        PR_POSTAL_CODE_W = 0x3A2A,

        [StringValue("3A2A")]
        PR_POSTAL_CODE_A = 0x3A2A,

        [StringValue("3A2A")]
        PR_BUSINESS_ADDRESS_POSTAL_CODE = 0x3A2A,

        [StringValue("3A2A")]
        PR_BUSINESS_ADDRESS_POSTAL_CODE_W = 0x3A2A,

        [StringValue("3A2A")]
        PR_BUSINESS_ADDRESS_POSTAL_CODE_A = 0x3A2A,

        [StringValue("3A2B")]
        PR_POST_OFFICE_BOX = 0x3A2B,

        [StringValue("3A2B")]
        PR_POST_OFFICE_BOX_W = 0x3A2B,

        [StringValue("3A2B")]
        PR_POST_OFFICE_BOX_A = 0x3A2B,

        [StringValue("3A2B")]
        PR_BUSINESS_ADDRESS_POST_OFFICE_BOX = 0x3A2B,

        [StringValue("3A2B")]
        PR_BUSINESS_ADDRESS_POST_OFFICE_BOX_W = 0x3A2B,

        [StringValue("3A2B")]
        PR_BUSINESS_ADDRESS_POST_OFFICE_BOX_A = 0x3A2B,

        [StringValue("3A2C")]
        PR_TELEX_NUMBER = 0x3A2C,

        [StringValue("3A2C")]
        PR_TELEX_NUMBER_W = 0x3A2C,

        [StringValue("3A2C")]
        PR_TELEX_NUMBER_A = 0x3A2C,

        [StringValue("3A2D")]
        PR_ISDN_NUMBER = 0x3A2D,

        [StringValue("3A2D")]
        PR_ISDN_NUMBER_W = 0x3A2D,

        [StringValue("3A2D")]
        PR_ISDN_NUMBER_A = 0x3A2D,

        [StringValue("3A2E")]
        PR_ASSISTANT_TELEPHONE_NUMBER = 0x3A2E,

        [StringValue("3A2E")]
        PR_ASSISTANT_TELEPHONE_NUMBER_W = 0x3A2E,

        [StringValue("3A2E")]
        PR_ASSISTANT_TELEPHONE_NUMBER_A = 0x3A2E,

        [StringValue("3A2F")]
        PR_HOME2_TELEPHONE_NUMBER = 0x3A2F,

        [StringValue("3A2F")]
        PR_HOME2_TELEPHONE_NUMBER_W = 0x3A2F,

        [StringValue("3A2F")]
        PR_HOME2_TELEPHONE_NUMBER_A = 0x3A2F,

        [StringValue("3A30")]
        PR_ASSISTANT = 0x3A30,

        [StringValue("3A30")]
        PR_ASSISTANT_W = 0x3A30,

        [StringValue("3A30")]
        PR_ASSISTANT_A = 0x3A30,

        [StringValue("3A40")]
        PR_SEND_RICH_INFO = 0x3A40,

        [StringValue("3A41")]
        PR_WEDDING_ANNIVERSARY = 0x3A41,

        [StringValue("3A42")]
        PR_BIRTHDAY = 0x3A42,

        [StringValue("3A43")]
        PR_HOBBIES = 0x3A43,

        [StringValue("3A43")]
        PR_HOBBIES_W = 0x3A43,

        [StringValue("3A43")]
        PR_HOBBIES_A = 0x3A43,

        [StringValue("3A44")]
        PR_MIDDLE_NAME = 0x3A44,

        [StringValue("3A44")]
        PR_MIDDLE_NAME_W = 0x3A44,

        [StringValue("3A44")]
        PR_MIDDLE_NAME_A = 0x3A44,

        [StringValue("3A45")]
        PR_DISPLAY_NAME_PREFIX = 0x3A45,

        [StringValue("3A45")]
        PR_DISPLAY_NAME_PREFIX_W = 0x3A45,

        [StringValue("3A45")]
        PR_DISPLAY_NAME_PREFIX_A = 0x3A45,

        [StringValue("3A46")]
        PR_PROFESSION = 0x3A46,

        [StringValue("3A46")]
        PR_PROFESSION_W = 0x3A46,

        [StringValue("3A46")]
        PR_PROFESSION_A = 0x3A46,

        [StringValue("3A47")]
        PR_PREFERRED_BY_NAME = 0x3A47,

        [StringValue("3A47")]
        PR_PREFERRED_BY_NAME_W = 0x3A47,

        [StringValue("3A47")]
        PR_PREFERRED_BY_NAME_A = 0x3A47,

        [StringValue("3A48")]
        PR_SPOUSE_NAME = 0x3A48,

        [StringValue("3A48")]
        PR_SPOUSE_NAME_W = 0x3A48,

        [StringValue("3A48")]
        PR_SPOUSE_NAME_A = 0x3A48,

        [StringValue("3A49")]
        PR_COMPUTER_NETWORK_NAME = 0x3A49,

        [StringValue("3A49")]
        PR_COMPUTER_NETWORK_NAME_W = 0x3A49,

        [StringValue("3A49")]
        PR_COMPUTER_NETWORK_NAME_A = 0x3A49,

        [StringValue("3A4A")]
        PR_CUSTOMER_ID = 0x3A4A,

        [StringValue("3A4A")]
        PR_CUSTOMER_ID_W = 0x3A4A,

        [StringValue("3A4A")]
        PR_CUSTOMER_ID_A = 0x3A4A,

        [StringValue("3A4B")]
        PR_TTYTDD_PHONE_NUMBER = 0x3A4B,

        [StringValue("3A4B")]
        PR_TTYTDD_PHONE_NUMBER_W = 0x3A4B,

        [StringValue("3A4B")]
        PR_TTYTDD_PHONE_NUMBER_A = 0x3A4B,

        [StringValue("3A4C")]
        PR_FTP_SITE = 0x3A4C,

        [StringValue("3A4C")]
        PR_FTP_SITE_W = 0x3A4C,

        [StringValue("3A4C")]
        PR_FTP_SITE_A = 0x3A4C,

        [StringValue("3A4D")]
        PR_GENDER = 0x3A4D,

        [StringValue("3A4E")]
        PR_MANAGER_NAME = 0x3A4E,

        [StringValue("3A4E")]
        PR_MANAGER_NAME_W = 0x3A4E,

        [StringValue("3A4E")]
        PR_MANAGER_NAME_A = 0x3A4E,

        [StringValue("3A4F")]
        PR_NICKNAME = 0x3A4F,

        [StringValue("3A4F")]
        PR_NICKNAME_W = 0x3A4F,

        [StringValue("3A4F")]
        PR_NICKNAME_A = 0x3A4F,

        [StringValue("3A50")]
        PR_PERSONAL_HOME_PAGE = 0x3A50,

        [StringValue("3A50")]
        PR_PERSONAL_HOME_PAGE_W = 0x3A50,

        [StringValue("3A50")]
        PR_PERSONAL_HOME_PAGE_A = 0x3A50,

        [StringValue("3A51")]
        PR_BUSINESS_HOME_PAGE = 0x3A51,

        [StringValue("3A51")]
        PR_BUSINESS_HOME_PAGE_W = 0x3A51,

        [StringValue("3A51")]
        PR_BUSINESS_HOME_PAGE_A = 0x3A51,

        [StringValue("3A52")]
        PR_CONTACT_VERSION = 0x3A52,

        [StringValue("3A53")]
        PR_CONTACT_ENTRYIDS = 0x3A53,

        [StringValue("3A54")]
        PR_CONTACT_ADDRTYPES = 0x3A54,

        [StringValue("3A54")]
        PR_CONTACT_ADDRTYPES_W = 0x3A54,

        [StringValue("3A54")]
        PR_CONTACT_ADDRTYPES_A = 0x3A54,

        [StringValue("3A55")]
        PR_CONTACT_DEFAULT_ADDRESS_INDEX = 0x3A55,

        [StringValue("3A56")]
        PR_CONTACT_EMAIL_ADDRESSES = 0x3A56,

        [StringValue("3A56")]
        PR_CONTACT_EMAIL_ADDRESSES_W = 0x3A56,

        [StringValue("3A56")]
        PR_CONTACT_EMAIL_ADDRESSES_A = 0x3A56,

        [StringValue("3A57")]
        PR_COMPANY_MAIN_PHONE_NUMBER = 0x3A57,

        [StringValue("3A57")]
        PR_COMPANY_MAIN_PHONE_NUMBER_W = 0x3A57,

        [StringValue("3A57")]
        PR_COMPANY_MAIN_PHONE_NUMBER_A = 0x3A57,

        [StringValue("3A58")]
        PR_CHILDRENS_NAMES = 0x3A58,

        [StringValue("3A58")]
        PR_CHILDRENS_NAMES_W = 0x3A58,

        [StringValue("3A58")]
        PR_CHILDRENS_NAMES_A = 0x3A58,

        [StringValue("3A59")]
        PR_HOME_ADDRESS_CITY = 0x3A59,

        [StringValue("3A59")]
        PR_HOME_ADDRESS_CITY_W = 0x3A59,

        [StringValue("3A59")]
        PR_HOME_ADDRESS_CITY_A = 0x3A59,

        [StringValue("3A5A")]
        PR_HOME_ADDRESS_COUNTRY = 0x3A5A,

        [StringValue("3A5A")]
        PR_HOME_ADDRESS_COUNTRY_W = 0x3A5A,

        [StringValue("3A5A")]
        PR_HOME_ADDRESS_COUNTRY_A = 0x3A5A,

        [StringValue("3A5B")]
        PR_HOME_ADDRESS_POSTAL_CODE = 0x3A5B,

        [StringValue("3A5B")]
        PR_HOME_ADDRESS_POSTAL_CODE_W = 0x3A5B,

        [StringValue("3A5B")]
        PR_HOME_ADDRESS_POSTAL_CODE_A = 0x3A5B,

        [StringValue("3A5C")]
        PR_HOME_ADDRESS_STATE_OR_PROVINCE = 0x3A5C,

        [StringValue("3A5C")]
        PR_HOME_ADDRESS_STATE_OR_PROVINCE_W = 0x3A5C,

        [StringValue("3A5C")]
        PR_HOME_ADDRESS_STATE_OR_PROVINCE_A = 0x3A5C,

        [StringValue("3A5D")]
        PR_HOME_ADDRESS_STREET = 0x3A5D,

        [StringValue("3A5D")]
        PR_HOME_ADDRESS_STREET_W = 0x3A5D,

        [StringValue("3A5D")]
        PR_HOME_ADDRESS_STREET_A = 0x3A5D,

        [StringValue("3A5E")]
        PR_HOME_ADDRESS_POST_OFFICE_BOX = 0x3A5E,

        [StringValue("3A5E")]
        PR_HOME_ADDRESS_POST_OFFICE_BOX_W = 0x3A5E,

        [StringValue("3A5E")]
        PR_HOME_ADDRESS_POST_OFFICE_BOX_A = 0x3A5E,

        [StringValue("3A5F")]
        PR_OTHER_ADDRESS_CITY = 0x3A5F,

        [StringValue("3A5F")]
        PR_OTHER_ADDRESS_CITY_W = 0x3A5F,

        [StringValue("3A5F")]
        PR_OTHER_ADDRESS_CITY_A = 0x3A5F,

        [StringValue("3A60")]
        PR_OTHER_ADDRESS_COUNTRY = 0x3A60,

        [StringValue("3A60")]
        PR_OTHER_ADDRESS_COUNTRY_W = 0x3A60,

        [StringValue("3A60")]
        PR_OTHER_ADDRESS_COUNTRY_A = 0x3A60,

        [StringValue("3A61")]
        PR_OTHER_ADDRESS_POSTAL_CODE = 0x3A61,

        [StringValue("3A61")]
        PR_OTHER_ADDRESS_POSTAL_CODE_W = 0x3A61,

        [StringValue("3A61")]
        PR_OTHER_ADDRESS_POSTAL_CODE_A = 0x3A61,

        [StringValue("3A62")]
        PR_OTHER_ADDRESS_STATE_OR_PROVINCE = 0x3A62,

        [StringValue("3A62")]
        PR_OTHER_ADDRESS_STATE_OR_PROVINCE_W = 0x3A62,

        [StringValue("3A62")]
        PR_OTHER_ADDRESS_STATE_OR_PROVINCE_A = 0x3A62,

        [StringValue("3A63")]
        PR_OTHER_ADDRESS_STREET = 0x3A63,

        [StringValue("3A63")]
        PR_OTHER_ADDRESS_STREET_W = 0x3A63,

        [StringValue("3A63")]
        PR_OTHER_ADDRESS_STREET_A = 0x3A63,

        [StringValue("3A64")]
        PR_OTHER_ADDRESS_POST_OFFICE_BOX = 0x3A64,

        [StringValue("3A64")]
        PR_OTHER_ADDRESS_POST_OFFICE_BOX_W = 0x3A64,

        [StringValue("3A64")]
        PR_OTHER_ADDRESS_POST_OFFICE_BOX_A = 0x3A64,

        /*
         *	Profile section properties"
         */

        [StringValue("3D00")]
        PR_STORE_PROVIDERS = 0x3D00,

        [StringValue("3D01")]
        PR_AB_PROVIDERS = 0x3D01,

        [StringValue("3D02")]
        PR_TRANSPORT_PROVIDERS = 0x3D02,

        [StringValue("3D04")]
        PR_DEFAULT_PROFILE = 0x3D04,

        [StringValue("3D05")]
        PR_AB_SEARCH_PATH = 0x3D05,

        [StringValue("3D06")]
        PR_AB_DEFAULT_DIR = 0x3D06,

        [StringValue("3D07")]
        PR_AB_DEFAULT_PAB = 0x3D07,

        [StringValue("3D08")]
        PR_FILTERING_HOOKS = 0x3D08,

        [StringValue("3D09")]
        PR_SERVICE_NAME = 0x3D09,

        [StringValue("3D09")]
        PR_SERVICE_NAME_W = 0x3D09,

        [StringValue("3D09")]
        PR_SERVICE_NAME_A = 0x3D09,

        [StringValue("3D0A")]
        PR_SERVICE_DLL_NAME = 0x3D0A,

        [StringValue("3D0A")]
        PR_SERVICE_DLL_NAME_W = 0x3D0A,

        [StringValue("3D0A")]
        PR_SERVICE_DLL_NAME_A = 0x3D0A,

        [StringValue("3D0B")]
        PR_SERVICE_ENTRY_NAME = 0x3D0B,

        [StringValue("3D0C")]
        PR_SERVICE_UID = 0x3D0C,

        [StringValue("3D0D")]
        PR_SERVICE_EXTRA_UIDS = 0x3D0D,

        [StringValue("3D0E")]
        PR_SERVICES = 0x3D0E,

        [StringValue("3D0F")]
        PR_SERVICE_SUPPORT_FILES = 0x3D0F,

        [StringValue("3D0F")]
        PR_SERVICE_SUPPORT_FILES_W = 0x3D0F,

        [StringValue("3D0F")]
        PR_SERVICE_SUPPORT_FILES_A = 0x3D0F,

        [StringValue("3D10")]
        PR_SERVICE_DELETE_FILES = 0x3D10,

        [StringValue("3D10")]
        PR_SERVICE_DELETE_FILES_W = 0x3D10,

        [StringValue("3D10")]
        PR_SERVICE_DELETE_FILES_A = 0x3D10,

        [StringValue("3D11")]
        PR_AB_SEARCH_PATH_UPDATE = 0x3D11,

        [StringValue("3D12")]
        PR_PROFILE_NAME = 0x3D12,

        [StringValue("3D12")]
        PR_PROFILE_NAME_A = 0x3D12,

        [StringValue("3D12")]
        PR_PROFILE_NAME_W = 0x3D12,

        /*
         *	Status object properties"
         */

        [StringValue("3E00")]
        PR_IDENTITY_DISPLAY = 0x3E00,

        [StringValue("3E00")]
        PR_IDENTITY_DISPLAY_W = 0x3E00,

        [StringValue("3E00")]
        PR_IDENTITY_DISPLAY_A = 0x3E00,

        [StringValue("3E01")]
        PR_IDENTITY_ENTRYID = 0x3E01,

        [StringValue("3E02")]
        PR_RESOURCE_METHODS = 0x3E02,

        [StringValue("3E03")]
        PR_RESOURCE_TYPE = 0x3E03,

        [StringValue("3E04")]
        PR_STATUS_CODE = 0x3E04,

        [StringValue("3E05")]
        PR_IDENTITY_SEARCH_KEY = 0x3E05,

        [StringValue("3E06")]
        PR_OWN_STORE_ENTRYID = 0x3E06,

        [StringValue("3E07")]
        PR_RESOURCE_PATH = 0x3E07,

        [StringValue("3E07")]
        PR_RESOURCE_PATH_W = 0x3E07,

        [StringValue("3E07")]
        PR_RESOURCE_PATH_A = 0x3E07,

        [StringValue("3E08")]
        PR_STATUS_STRING = 0x3E08,

        [StringValue("3E08")]
        PR_STATUS_STRING_W = 0x3E08,

        [StringValue("3E08")]
        PR_STATUS_STRING_A = 0x3E08,

        [StringValue("3E09")]
        PR_X400_DEFERRED_DELIVERY_CANCEL = 0x3E09,

        [StringValue("3E0A")]
        PR_HEADER_FOLDER_ENTRYID = 0x3E0A,

        [StringValue("3E0B")]
        PR_REMOTE_PROGRESS = 0x3E0B,

        [StringValue("3E0C")]
        PR_REMOTE_PROGRESS_TEXT = 0x3E0C,

        [StringValue("3E0C")]
        PR_REMOTE_PROGRESS_TEXT_W = 0x3E0C,

        [StringValue("3E0C")]
        PR_REMOTE_PROGRESS_TEXT_A = 0x3E0C,

        [StringValue("3E0D")]
        PR_REMOTE_VALIDATE_OK = 0x3E0D,

        /*
         * Display table properties
         */

        [StringValue("3F00")]
        PR_CONTROL_FLAGS = 0x3F00,

        [StringValue("3F01")]
        PR_CONTROL_STRUCTURE = 0x3F01,

        [StringValue("3F02")]
        PR_CONTROL_TYPE = 0x3F02,

        [StringValue("3F03")]
        PR_DELTAX = 0x3F03,

        [StringValue("3F04")]
        PR_DELTAY = 0x3F04,

        [StringValue("3F05")]
        PR_XPOS = 0x3F05,

        [StringValue("3F06")]
        PR_YPOS = 0x3F06,

        [StringValue("3F07")]
        PR_CONTROL_ID = 0x3F07,

        [StringValue("3F08")]
        PR_INITIAL_DETAILS_PANE = 0x3F08,

        /*
         * Secure property id range
         */

        [StringValue("67F0")]
        PROP_ID_SECURE_MIN = 0x67F0,

        [StringValue("67FF")]
        PROP_ID_SECURE_MAX = 0x67FF,
        /* MAPITAGS_H */
        #endregion
    
        #region Flag constants
        /// <summary>
        ///     E-mail follow up flag (named property)
        /// </summary>
        [StringValue("8530")]
        FlagRequest = 0x8530,

        /// <summary>
        ///     Specifies the flag state of the message object; Not present, 1 = Completed, 2 = Flagged.
        ///     Only available from Outlook 2007 and up.
        /// </summary>
        [StringValue("1090")]
        PR_FLAG_STATUS = 0x1090,

        /// <summary>
        ///     Contains the date when the task was completed. Only filled when <see cref="TaskComplete" /> is true.
        ///     Only available from Outlook 2007 and up.
        /// </summary>
        [StringValue("1091")]
        PR_FLAG_COMPLETE_TIME = 0x1091,
        #endregion

        #region Task constants
        /// <summary>
        ///     <see cref="TaskStatus" /> of the task (named property)
        /// </summary>
        [StringValue("8101")]
        TaskStatus = 0x8101,

        /// <summary>
        ///     Start date of the task (named property)
        /// </summary>
        [StringValue("8104")]
        TaskStartDate = 0x8104,

        /// <summary>
        ///     Due date of the task (named property)
        /// </summary>
        [StringValue("8105")]
        TaskDueDate = 0x8105,

        /// <summary>
        ///     True when the task is complete (named property)
        /// </summary>
        [StringValue("811C")]
        TaskComplete = 0x811C,

        /// <summary>
        ///     The actual task effort in minutes (named property)
        /// </summary>
        [StringValue("8110")]
        TaskActualEffort = 0x8110,

        /// <summary>
        ///     The estimated task effort in minutes (named property)
        /// </summary>
        [StringValue("8111")]
        TaskEstimatedEffort = 0x8111,

        /// <summary>
        ///     The complete percentage of the task (named property)
        /// </summary>
        [StringValue("8102")]
        PercentComplete = 0x8102,

        /// <summary>
        ///     The contacts of the task (named property)
        /// </summary>
        [StringValue("853A")]
        Contacts = 0x853A,

        /// <summary>
        ///     The companies for the task (named property)
        /// </summary>
        [StringValue("8539")]
        Companies = 0x8539,

        /// <summary>
        ///     The task billing information (named property)
        /// </summary>
        [StringValue("8535")]
        Billing = 0x8535,

        /// <summary>
        ///     The task mileage information (named property)
        /// </summary>
        [StringValue("8534")]
        Mileage = 0x8534,

        /// <summary>
        ///     The task owner (named property)
        /// </summary>
        [StringValue("811F")]
        Owner = 0x811F,
        #endregion

        #region Appointment constants
        /// <summary>
        ///     Appointment location (named property)
        /// </summary>
        [StringValue("8208")]
        Location = 0x8208,

        /// <summary>
        ///     Appointment reccurence type (named property)
        /// </summary>
        [StringValue("8231")]
        ReccurrenceType = 0x8231,

        /// <summary>
        ///     Appointment reccurence pattern (named property)
        /// </summary>
        [StringValue("8232")]
        ReccurrencePattern = 0x8232,

        /// <summary>
        ///     Appointment start time (greenwich time) (named property)
        /// </summary>
        [StringValue("820D")]
        AppointmentStartWhole = 0x820D,

        /// <summary>
        ///     Appointment end time (greenwich time) (named property)
        /// </summary>
        [StringValue("820E")]
        AppointmentEndWhole = 0x820E,

        /// <summary>
        ///     Appointment all attendees string (named property)
        /// </summary>
        [StringValue("8238")]
        AppointmentAllAttendees = 0x8238,

        /// <summary>
        ///     Appointment to attendees string (named property)
        /// </summary>
        [StringValue("823B")]
        AppointmentToAttendees = 0x823B,

        /// <summary>
        ///     Appointment cc attendees string (named property)
        /// </summary>
        [StringValue("823C")]
        AppointmentCCAttendees = 0x823C,

        /// <summary>
        ///     The PidLidClientIntent property ([MS-OXPROPS] section 2.58) indicates what actions a user has taken on a Meeting object
        /// </summary>
        [StringValue("0015")]
        PidLidClientIntent = 0x0015,
        #endregion

        #region Contact constants
        /// <summary>
        /// Instant messaging address (named property)    
        /// </summary>
        [StringValue("8062")]
        InstantMessagingAddress = 0x8062,

        /// <summary>
        /// Home address (named property)
        /// </summary>
        [StringValue("801A")]
        HomeAddress = 0x801A,

        /// <summary>
        /// Work address (named property)
        /// </summary>
        [StringValue("801B")]
        WorkAddress = 0x801B,

        /// <summary>
        /// Other address (named property)
        /// </summary>
        [StringValue("801C")]
        OtherAddress = 0x801C,

        /// <summary>
        /// E-mail 1 address (named property)
        /// </summary>
        [StringValue("8083")]
        Email1EmailAddress = 0x8083,

        /// <summary>
        /// E-mail 1 display name (named property
        /// </summary>
        [StringValue("8080")]
        Email1DisplayName = 0x8080,

        /// <summary>
        /// E-mail 2 address (named property)
        /// </summary>
        [StringValue("8093")]
        Email2EmailAddress = 0x8093,

        /// <summary>
        /// E-mail 2 display name (named property
        /// </summary>
        [StringValue("8090")]
        Email2DisplayName = 0x8090,

        /// <summary>
        /// E-mail 3 address (named property)
        /// </summary>
        [StringValue("80A3")]
        Email3EmailAddress = 0x80A3,

        /// <summary>
        /// E-mail 3 display name (named property)
        /// </summary>
        [StringValue("80A0")]
        Email3DisplayName = 0x80A0,

        /// <summary>
        /// Html (named property)
        /// </summary>
        [StringValue("802B")]
        Html = 0x802B,
        #endregion

        /// <summary>
        /// Contains the format of the Simple Mail Transport Protocol (SMTP) email address of the sending mailbox owner
        /// </summary>
        [StringValue("5D01")]
        PR_SENDER_SMTP_ADDRESS = 0x5D01,

        /// <summary>
        /// Contains the Simple Mail Transport Protocol (SMTP) email address for the messaging 
        /// user who is represented by the sender
        /// </summary>
        [StringValue("5D02")]
        PR_SENT_REPRESENTING_SMTP_ADDRESS = 0x5D02,

        /// <summary>
        /// Contains the name of the last user (or creator) to change the Message object 
        /// </summary>
        [StringValue("3FFA")]
        PR_LAST_MODIFIER_NAME_W = 0x3FFA,

        /// <summary>
        /// Can contain the E-mail address of the sender (named property)
        /// </summary>
        [StringValue("8580")]
        InternetAccountName = 0x8580,

        /// <summary>
        /// Contains the code page that is used in HTML when this is added in binary format
        /// </summary>
        [StringValue("66C3")]
        PR_CODE_PAGE_ID = 0x66C3,

        /// <summary>
        /// Contains the language client used to create the message.
        /// </summary>
        [StringValue("3FF1")]
        PR_MESSAGE_LOCALE_ID = 0x3FF1,

        /// <summary>
        /// Contains the code page that is used in the body
        /// </summary>
        [StringValue("3FFD")]
        PR_MESSAGE_CODEPAGE = 0x3FFD,

        /// <summary>
        /// Indicates the code page used for PR_BODY (PidTagBody) or PR_BODY_HTML (PidTagBodyHtml) properties.
        /// </summary>
        [StringValue("3FDE")]
        PR_INTERNET_CPID = 0x3FDE,

        /// <summary>
        /// Corresponds to the message ID field as specified in [RFC2822].
        /// </summary>
        [StringValue("1035")]
        PR_INTERNET_MESSAGE_ID = 0x1035,
        // ReSharper restore InconsistentNaming
    }
}