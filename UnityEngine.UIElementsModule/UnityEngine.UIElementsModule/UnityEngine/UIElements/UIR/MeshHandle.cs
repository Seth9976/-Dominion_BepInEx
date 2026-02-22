using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000D8 RID: 216
	public class MeshHandle : LinkedPoolItem<MeshHandle>
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x000315D0 File Offset: 0x0002F7D0
		// Note: this type is marked as 'beforefieldinit'.
		static MeshHandle()
		{
			Il2CppClassPointerStore<MeshHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "MeshHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr);
			MeshHandle.NativeFieldInfoPtr_allocVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "allocVerts");
			MeshHandle.NativeFieldInfoPtr_allocIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "allocIndices");
			MeshHandle.NativeFieldInfoPtr_triangleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "triangleCount");
			MeshHandle.NativeFieldInfoPtr_allocPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "allocPage");
			MeshHandle.NativeFieldInfoPtr_allocTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "allocTime");
			MeshHandle.NativeFieldInfoPtr_updateAllocID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshHandle>.NativeClassPtr, "updateAllocID");
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00007A76 File Offset: 0x00005C76
		public MeshHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00031678 File Offset: 0x0002F878
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00007A7F File Offset: 0x00005C7F
		public Alloc allocVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocVerts);
				return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocVerts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x000316A8 File Offset: 0x0002F8A8
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00007AAD File Offset: 0x00005CAD
		public Alloc allocIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocIndices);
				return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000316D8 File Offset: 0x0002F8D8
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00007ADB File Offset: 0x00005CDB
		public unsafe uint triangleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_triangleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_triangleCount)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00031700 File Offset: 0x0002F900
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00007AF6 File Offset: 0x00005CF6
		public unsafe Page allocPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocPage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Page>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocPage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00031730 File Offset: 0x0002F930
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00007B15 File Offset: 0x00005D15
		public unsafe uint allocTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_allocTime)) = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00031758 File Offset: 0x0002F958
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00007B30 File Offset: 0x00005D30
		public unsafe uint updateAllocID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_updateAllocID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshHandle.NativeFieldInfoPtr_updateAllocID)) = value;
			}
		}

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_allocVerts;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_allocIndices;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_triangleCount;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_allocPage;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_allocTime;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_updateAllocID;
	}
}
