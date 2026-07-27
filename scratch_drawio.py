import os

xml_content = """<?xml version="1.0" encoding="UTF-8"?>
<mxfile host="app.diagrams.net" modified="2026-07-28T00:00:00.000Z" agent="Antigravity" version="21.0.0" type="device">
  <diagram id="english-lms-context" name="EnglishLMS Context Diagram">
    <mxGraphModel dx="1600" dy="1100" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="2000" pageHeight="1400" math="0" shadow="0">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />

        <!-- Central System Process (Circle) -->
        <mxCell id="sys_lms" value="&lt;b style=&quot;font-size: 16px;&quot;&gt;English Elearning&lt;br/&gt;Management System&lt;/b&gt;&lt;br/&gt;&lt;span style=&quot;font-size: 13px; color: #2b579a;&quot;&gt;(EnglishLMS C# .NET Core)&lt;/span&gt;" style="ellipse;whiteSpace=wrap;html=1;aspect=fixed;fillColor=#dae8fc;strokeColor=#6c8ebf;strokeWidth=3;fontSize=14;align=center;fontColor=#1d2a44;" vertex="1" parent="1">
          <mxGeometry x="780" y="460" width="300" height="300" as="geometry" />
        </mxCell>

        <!-- External Entities / Actors (Yellow Boxes) -->
        <mxCell id="actor_student" value="&lt;b style=&quot;font-size: 15px;&quot;&gt;Student&lt;/b&gt;&lt;br/&gt;(Học viên)" style="rounded=1;whiteSpace=wrap;html=1;fillColor=#fff2cc;strokeColor=#d6b656;strokeWidth=2;fontSize=13;fontColor=#4c3d00;" vertex="1" parent="1">
          <mxGeometry x="100" y="480" width="200" height="120" as="geometry" />
        </mxCell>

        <mxCell id="actor_instructor" value="&lt;b style=&quot;font-size: 15px;&quot;&gt;Instructor&lt;/b&gt;&lt;br/&gt;(Giảng viên)" style="rounded=1;whiteSpace=wrap;html=1;fillColor=#fff2cc;strokeColor=#d6b656;strokeWidth=2;fontSize=13;fontColor=#4c3d00;" vertex="1" parent="1">
          <mxGeometry x="830" y="60" width="200" height="110" as="geometry" />
        </mxCell>

        <mxCell id="actor_parent" value="&lt;b style=&quot;font-size: 15px;&quot;&gt;Parent&lt;/b&gt;&lt;br/&gt;(Phụ huynh)" style="rounded=1;whiteSpace=wrap;html=1;fillColor=#fff2cc;strokeColor=#d6b656;strokeWidth=2;fontSize=13;fontColor=#4c3d00;" vertex="1" parent="1">
          <mxGeometry x="180" y="980" width="200" height="110" as="geometry" />
        </mxCell>

        <mxCell id="actor_manager" value="&lt;b style=&quot;font-size: 15px;&quot;&gt;Manager / Admin&lt;/b&gt;&lt;br/&gt;(Quản lý / Quản trị)" style="rounded=1;whiteSpace=wrap;html=1;fillColor=#fff2cc;strokeColor=#d6b656;strokeWidth=2;fontSize=13;fontColor=#4c3d00;" vertex="1" parent="1">
          <mxGeometry x="1520" y="140" width="210" height="120" as="geometry" />
        </mxCell>

        <!-- External Systems (Purple Boxes) -->
        <mxCell id="ext_vnpay" value="&lt;b style=&quot;font-size: 15px;&quot;&gt;VNPay Gateway&lt;/b&gt;&lt;br/&gt;(Cổng thanh toán)" style="rounded=1;whiteSpace=wrap;html=1;fillColor=#e1d5e7;strokeColor=#9673a6;strokeWidth=2;fontSize=13;fontColor=#3b234a;" vertex="1" parent="1">
          <mxGeometry x="630" y="1040" width="200" height="110" as="geometry" />
        </mxCell>

        <mxCell id="ext_cloudinary" value="&lt;b style=&quot;font-size: 15px;&quot;&gt;Cloudinary&lt;/b&gt;&lt;br/&gt;(Lưu trữ Media)" style="rounded=1;whiteSpace=wrap;html=1;fillColor=#e1d5e7;strokeColor=#9673a6;strokeWidth=2;fontSize=13;fontColor=#3b234a;" vertex="1" parent="1">
          <mxGeometry x="1560" y="470" width="200" height="110" as="geometry" />
        </mxCell>

        <mxCell id="ext_gmail" value="&lt;b style=&quot;font-size: 15px;&quot;&gt;Gmail / SMTP&lt;/b&gt;&lt;br/&gt;(Email &amp; OTP)" style="rounded=1;whiteSpace=wrap;html=1;fillColor=#e1d5e7;strokeColor=#9673a6;strokeWidth=2;fontSize=13;fontColor=#3b234a;" vertex="1" parent="1">
          <mxGeometry x="1520" y="740" width="200" height="110" as="geometry" />
        </mxCell>

        <mxCell id="ext_fido2" value="&lt;b style=&quot;font-size: 15px;&quot;&gt;FIDO2 / WebAuthn&lt;/b&gt;&lt;br/&gt;(Xác thực Passkey)" style="rounded=1;whiteSpace=wrap;html=1;fillColor=#e1d5e7;strokeColor=#9673a6;strokeWidth=2;fontSize=13;fontColor=#3b234a;" vertex="1" parent="1">
          <mxGeometry x="1050" y="1040" width="200" height="110" as="geometry" />
        </mxCell>


        <!-- EDGES & DATA FLOWS -->

        <!-- Student -> System -->
        <mxCell id="e_std_in_1" value="Đăng ký, Đăng nhập, Passkey" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;entryX=0;entryY=0.25;entryDx=0;entryDy=0;exitX=1;exitY=0.15;exitDx=0;exitDy=0;" edge="1" parent="1" source="actor_student" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_std_in_2" value="Bài làm Quiz &amp; Assignment, Thảo luận" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;entryX=0;entryY=0.45;entryDx=0;entryDy=0;exitX=1;exitY=0.45;exitDx=0;exitDy=0;" edge="1" parent="1" source="actor_student" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_std_in_3" value="Yêu cầu / Mã liên kết Phụ huynh" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;entryX=0;entryY=0.65;entryDx=0;entryDy=0;exitX=1;exitY=0.75;exitDx=0;exitDy=0;" edge="1" parent="1" source="actor_student" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- System -> Student -->
        <mxCell id="e_lms_std_1" value="Nội dung khóa học, Video, Flashcard" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0;exitY=0.35;exitDx=0;exitDy=0;entryX=1;entryY=0.3;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_student">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_lms_std_2" value="Điểm số, Phản hồi Quiz/Assignment" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0;exitY=0.55;exitDx=0;exitDy=0;entryX=1;entryY=0.6;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_student">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_lms_std_3" value="Báo cáo tiến độ &amp; Thống kê từ vựng" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0;exitY=0.75;exitDx=0;exitDy=0;entryX=1;entryY=0.9;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_student">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- Instructor -> System -->
        <mxCell id="e_ins_in_1" value="Soạn bài học, Module, bộ Quiz &amp; Flashcard" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;exitX=0.25;exitY=1;exitDx=0;exitDy=0;entryX=0.35;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="actor_instructor" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_ins_in_2" value="Gửi đề xuất phê duyệt khóa học (CourseRequest)" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;exitX=0.45;exitY=1;exitDx=0;exitDy=0;entryX=0.55;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="actor_instructor" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_ins_in_3" value="Chấm điểm &amp; Nhận xét bài làm" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;exitX=0.65;exitY=1;exitDx=0;exitDy=0;entryX=0.75;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="actor_instructor" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- System -> Instructor -->
        <mxCell id="e_lms_ins_1" value="Danh sách bài nộp của học viên" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0.25;exitY=0;exitDx=0;exitDy=0;entryX=0.15;entryY=1;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_instructor">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_lms_ins_2" value="Kết quả phê duyệt khóa học" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0.65;exitY=0;exitDx=0;exitDy=0;entryX=0.55;entryY=1;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_instructor">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_lms_ins_3" value="Thống kê tiến độ học viên &amp; Lớp học" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0.85;exitY=0;exitDx=0;exitDy=0;entryX=0.85;entryY=1;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_instructor">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- Parent -> System -->
        <mxCell id="e_prt_in_1" value="Xác nhận / Gửi liên kết tài khoản con" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;exitX=0.7;exitY=0;exitDx=0;exitDy=0;entryX=0.1;entryY=0.85;entryDx=0;entryDy=0;" edge="1" parent="1" source="actor_parent" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_prt_in_2" value="Yêu cầu mua khóa học &amp; Thanh toán" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;exitX=0.9;exitY=0;exitDx=0;exitDy=0;entryX=0.2;entryY=0.95;entryDx=0;entryDy=0;" edge="1" parent="1" source="actor_parent" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- System -> Parent -->
        <mxCell id="e_lms_prt_1" value="Báo cáo tiến độ &amp; Điểm số của con" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0.05;exitY=0.75;exitDx=0;exitDy=0;entryX=0.4;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_parent">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_lms_prt_2" value="Danh sách khoản cần thanh toán &amp; Xác nhận" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0.15;exitY=0.9;exitDx=0;exitDy=0;entryX=0.6;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_parent">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- Manager -> System -->
        <mxCell id="e_mng_in_1" value="Phê duyệt / Từ chối khóa học" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;exitX=0;exitY=0.3;exitDx=0;exitDy=0;entryX=0.9;entryY=0.15;entryDx=0;entryDy=0;" edge="1" parent="1" source="actor_manager" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_mng_in_2" value="Quản lý Người dùng, Role &amp; Phân quyền" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;exitX=0;exitY=0.6;exitDx=0;exitDy=0;entryX=0.95;entryY=0.3;entryDx=0;entryDy=0;" edge="1" parent="1" source="actor_manager" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_mng_in_3" value="Quản lý Danh mục &amp; Cấu hình hệ thống" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#d6b656;exitX=0;exitY=0.9;exitDx=0;exitDy=0;entryX=1;entryY=0.45;entryDx=0;entryDy=0;" edge="1" parent="1" source="actor_manager" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- System -> Manager -->
        <mxCell id="e_lms_mng_1" value="Danh sách khóa học chờ duyệt" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0.85;exitY=0.1;exitDx=0;exitDy=0;entryX=0.2;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_manager">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_lms_mng_2" value="Thống kê tổng quan &amp; Báo cáo doanh thu" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0.98;exitY=0.25;exitDx=0;exitDy=0;entryX=0.1;entryY=0.4;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_manager">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_lms_mng_3" value="Nhật ký hệ thống &amp; Audit Logs" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#6c8ebf;exitX=0.95;exitY=0.4;exitDx=0;exitDy=0;entryX=0.1;entryY=0.8;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="actor_manager">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- System <-> VNPay -->
        <mxCell id="e_lms_vnp" value="Yêu cầu thanh toán (TxnRef, Amount, OrderInfo)" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#9673a6;exitX=0.35;exitY=1;exitDx=0;exitDy=0;entryX=0.4;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="ext_vnpay">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_vnp_lms" value="Kết quả giao dịch (Callback / IPN parameters)" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#9673a6;exitX=0.7;exitY=0;exitDx=0;exitDy=0;entryX=0.5;entryY=1;entryDx=0;entryDy=0;" edge="1" parent="1" source="ext_vnpay" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- System <-> Cloudinary -->
        <mxCell id="e_lms_cld" value="Upload Media request (Video, Image, Attachment)" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#9673a6;exitX=0.98;exitY=0.55;exitDx=0;exitDy=0;entryX=0;entryY=0.3;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="ext_cloudinary">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_cld_lms" value="Media CDN URL &amp; Upload status" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#9673a6;exitX=0;exitY=0.7;exitDx=0;exitDy=0;entryX=0.95;entryY=0.65;exitDx=0;exitDy=0;" edge="1" parent="1" source="ext_cloudinary" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- System <-> Gmail / SMTP -->
        <mxCell id="e_lms_gml" value="Yêu cầu gửi Email xác thực, OTP, Hóa đơn" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#9673a6;exitX=0.9;exitY=0.8;exitDx=0;exitDy=0;entryX=0;entryY=0.3;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="ext_gmail">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_gml_lms" value="Trạng thái gửi Email" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#9673a6;exitX=0;exitY=0.7;exitDx=0;exitDy=0;entryX=0.85;entryY=0.9;entryDx=0;entryDy=0;" edge="1" parent="1" source="ext_gmail" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- System <-> FIDO2 -->
        <mxCell id="e_lms_fdo" value="Đăng ký Passkey &amp; Challenge xác thực" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#9673a6;exitX=0.7;exitY=0.95;exitDx=0;exitDy=0;entryX=0.3;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="sys_lms" target="ext_fido2">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="e_fdo_lms" value="Xác minh chữ ký Passkey thành công" style="edgeStyle=orthogonalEdgeStyle;rounded=0;html=1;fontSize=11;strokeWidth=1.5;strokeColor=#9673a6;exitX=0.7;exitY=0;exitDx=0;exitDy=0;entryX=0.8;entryY=0.9;entryDx=0;entryDy=0;" edge="1" parent="1" source="ext_fido2" target="sys_lms">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

      </root>
    </mxGraphModel>
  </diagram>
</mxfile>
"""

file_path = "c:\\Users\\quanb\\Downloads\\EnglishLms\\english_lms_context_diagram.drawio"
with open(file_path, "w", encoding="utf-8") as f:
    f.write(xml_content.strip())

print("Successfully saved to", file_path)
