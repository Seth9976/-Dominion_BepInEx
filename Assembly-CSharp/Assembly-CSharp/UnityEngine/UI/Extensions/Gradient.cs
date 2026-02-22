using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200011A RID: 282
	public class Gradient : BaseMeshEffect
	{
		// Token: 0x0600206D RID: 8301 RVA: 0x0007C9E0 File Offset: 0x0007ABE0
		// Note: this type is marked as 'beforefieldinit'.
		static Gradient()
		{
			Il2CppClassPointerStore<Gradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "Gradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gradient>.NativeClassPtr);
			Gradient.NativeFieldInfoPtr_gradientMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "gradientMode");
			Gradient.NativeFieldInfoPtr_gradientDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "gradientDir");
			Gradient.NativeFieldInfoPtr_overwriteAllColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "overwriteAllColor");
			Gradient.NativeFieldInfoPtr_vertex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "vertex1");
			Gradient.NativeFieldInfoPtr_vertex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "vertex2");
			Gradient.NativeFieldInfoPtr_targetGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "targetGraphic");
			Gradient.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665936);
			Gradient.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665937);
			Gradient.NativeMethodInfoPtr_CompareCarefully_Private_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665938);
			Gradient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665939);
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x0007CAD8 File Offset: 0x0007ACD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257501, XrefRangeEnd = 257504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0007CB14 File Offset: 0x0007AD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257504, XrefRangeEnd = 257534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0007CB64 File Offset: 0x0007AD64
		[CallerCount(0)]
		public unsafe bool CompareCarefully(Color col1, Color col2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref col1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_CompareCarefully_Private_Boolean_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0007CBBC File Offset: 0x0007ADBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257534, XrefRangeEnd = 257537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gradient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gradient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x0001428C File Offset: 0x0001248C
		public Gradient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x0007CBF8 File Offset: 0x0007ADF8
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00014295 File Offset: 0x00012495
		public unsafe GradientMode gradientMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_gradientMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_gradientMode)) = value;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0007CC20 File Offset: 0x0007AE20
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x000142B0 File Offset: 0x000124B0
		public unsafe GradientDir gradientDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_gradientDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_gradientDir)) = value;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0007CC48 File Offset: 0x0007AE48
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x000142CB File Offset: 0x000124CB
		public unsafe bool overwriteAllColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_overwriteAllColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_overwriteAllColor)) = value;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0007CC70 File Offset: 0x0007AE70
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x000142E6 File Offset: 0x000124E6
		public unsafe Color vertex1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_vertex1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_vertex1)) = value;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x0007CC98 File Offset: 0x0007AE98
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x00014301 File Offset: 0x00012501
		public unsafe Color vertex2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_vertex2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_vertex2)) = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x0007CCC0 File Offset: 0x0007AEC0
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x0001431C File Offset: 0x0001251C
		public unsafe Graphic targetGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_targetGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_targetGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeFieldInfoPtr_gradientMode;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeFieldInfoPtr_gradientDir;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeFieldInfoPtr_overwriteAllColor;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeFieldInfoPtr_vertex1;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeFieldInfoPtr_vertex2;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeFieldInfoPtr_targetGraphic;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr_CompareCarefully_Private_Boolean_Color_Color_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
