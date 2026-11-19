# EducationCentre ERD (placeholder)

The schema is planned as one shared PostgreSQL database with tenant-scoped
module tables. The following table groups are reserved in the design:

- **Identity:** `platform_admins`, `tenants`, `iam_users`, `iam_roles`,
  `iam_user_roles`, `iam_outbox_messages`
- **Academic:** `academic_units`, `courses`, `batches`, `batch_instructors`,
  `enrollments`, `academic_outbox_messages`
- **Attendance:** `attendance_sessions`, `attendance_records`,
  `attendance_justifications`, `attendance_summary`,
  `attendance_summary_documents`, `wifi_whitelist`, `session_allowed_wifi`,
  `attendance_outbox_messages`
- **Examination:** `examination_assessment_components`,
  `examination_course_weights`, `examination_scores`,
  `examination_final_grades`, `examination_result_documents`,
  `examination_outbox_messages`
- **Discussion:** `discussion_channels`, `discussion_messages`,
  `discussion_participants`, `discussion_outbox_messages`
- **Notification:** `notifications`, `emails`
- **Audit:** `audit_events`
- **Content:** `content_items`, `content_versions`, `content_attachments`,
  `search_sync_log`, `content_outbox_messages`

Foreign keys, column definitions, indexes, and tenant-filter implementation
remain to be defined alongside the module domain models and migrations.
