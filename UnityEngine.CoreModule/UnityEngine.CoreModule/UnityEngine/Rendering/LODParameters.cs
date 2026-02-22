using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000140 RID: 320
	[StructLayout(2)]
	public struct LODParameters
	{
		// Token: 0x06001808 RID: 6152 RVA: 0x00059804 File Offset: 0x00057A04
		// Note: this type is marked as 'beforefieldinit'.
		static LODParameters()
		{
			Il2CppClassPointerStore<LODParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LODParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODParameters>.NativeClassPtr);
			LODParameters.NativeFieldInfoPtr_m_IsOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_IsOrthographic");
			LODParameters.NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPosition");
			LODParameters.NativeFieldInfoPtr_m_FieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_FieldOfView");
			LODParameters.NativeFieldInfoPtr_m_OrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_OrthoSize");
			LODParameters.NativeFieldInfoPtr_m_CameraPixelHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPixelHeight");
			LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100665096);
			LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100665097);
			LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100665098);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000598D4 File Offset: 0x00057AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82252, XrefRangeEnd = 82255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LODParameters other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00059914 File Offset: 0x00057B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82255, XrefRangeEnd = 82262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00059958 File Offset: 0x00057B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82262, XrefRangeEnd = 82265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x0000D815 File Offset: 0x0000BA15
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00059988 File Offset: 0x00057B88
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x0000D827 File Offset: 0x0000BA27
		public bool isOrthographic
		{
			get
			{
				return Convert.ToBoolean(this.m_IsOrthographic);
			}
			set
			{
				this.m_IsOrthographic = Convert.ToInt32(value);
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x000599A8 File Offset: 0x00057BA8
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x0000D836 File Offset: 0x0000BA36
		public Vector3 cameraPosition
		{
			get
			{
				return this.m_CameraPosition;
			}
			set
			{
				this.m_CameraPosition = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x000599C0 File Offset: 0x00057BC0
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x0000D840 File Offset: 0x0000BA40
		public float fieldOfView
		{
			get
			{
				return this.m_FieldOfView;
			}
			set
			{
				this.m_FieldOfView = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000599D8 File Offset: 0x00057BD8
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x0000D84A File Offset: 0x0000BA4A
		public float orthoSize
		{
			get
			{
				return this.m_OrthoSize;
			}
			set
			{
				this.m_OrthoSize = value;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000599F0 File Offset: 0x00057BF0
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0000D854 File Offset: 0x0000BA54
		public int cameraPixelHeight
		{
			get
			{
				return this.m_CameraPixelHeight;
			}
			set
			{
				this.m_CameraPixelHeight = value;
			}
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00059A08 File Offset: 0x00057C08
		public static bool operator ==(LODParameters left, LODParameters right)
		{
			return left.Equals(right);
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00059A24 File Offset: 0x00057C24
		public static bool operator !=(LODParameters left, LODParameters right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOrthographic;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPosition;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeFieldInfoPtr_m_FieldOfView;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeFieldInfoPtr_m_OrthoSize;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPixelHeight;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011ED RID: 4589
		[FieldOffset(0)]
		public int m_IsOrthographic;

		// Token: 0x040011EE RID: 4590
		[FieldOffset(4)]
		public Vector3 m_CameraPosition;

		// Token: 0x040011EF RID: 4591
		[FieldOffset(16)]
		public float m_FieldOfView;

		// Token: 0x040011F0 RID: 4592
		[FieldOffset(20)]
		public float m_OrthoSize;

		// Token: 0x040011F1 RID: 4593
		[FieldOffset(24)]
		public int m_CameraPixelHeight;
	}
}
