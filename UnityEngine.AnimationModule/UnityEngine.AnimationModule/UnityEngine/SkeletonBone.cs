using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public sealed class SkeletonBone : ValueType
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x00008D3C File Offset: 0x00006F3C
		// Note: this type is marked as 'beforefieldinit'.
		static SkeletonBone()
		{
			Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "SkeletonBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr);
			SkeletonBone.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "name");
			SkeletonBone.NativeFieldInfoPtr_parentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "parentName");
			SkeletonBone.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "position");
			SkeletonBone.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "rotation");
			SkeletonBone.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr, "scale");
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000032F0 File Offset: 0x000014F0
		public SkeletonBone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000032F9 File Offset: 0x000014F9
		public SkeletonBone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkeletonBone>.NativeClassPtr))
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00008DD0 File Offset: 0x00006FD0
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0000330B File Offset: 0x0000150B
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00008DF8 File Offset: 0x00006FF8
		// (set) Token: 0x060001CD RID: 461 RVA: 0x0000332A File Offset: 0x0000152A
		public unsafe string parentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_parentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_parentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00008E20 File Offset: 0x00007020
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00003349 File Offset: 0x00001549
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00008E48 File Offset: 0x00007048
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00003364 File Offset: 0x00001564
		public unsafe Quaternion rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00008E70 File Offset: 0x00007070
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0000337F File Offset: 0x0000157F
		public unsafe Vector3 scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkeletonBone.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00008E98 File Offset: 0x00007098
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0000339A File Offset: 0x0000159A
		public int transformModified
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_parentName;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_scale;
	}
}
