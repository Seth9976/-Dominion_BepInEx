using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000AE RID: 174
	public sealed class Coroutine : YieldInstruction
	{
		// Token: 0x06001040 RID: 4160 RVA: 0x00042994 File Offset: 0x00040B94
		// Note: this type is marked as 'beforefieldinit'.
		static Coroutine()
		{
			Il2CppClassPointerStore<Coroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Coroutine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coroutine>.NativeClassPtr);
			Coroutine.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "m_Ptr");
			Coroutine.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664358);
			Coroutine.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664359);
			Coroutine.NativeMethodInfoPtr_ReleaseCoroutine_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664360);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00042A14 File Offset: 0x00040C14
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coroutine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00042A50 File Offset: 0x00040C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69893, XrefRangeEnd = 69898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00042A84 File Offset: 0x00040C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69898, XrefRangeEnd = 69900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseCoroutine(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_ReleaseCoroutine_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0000A17D File Offset: 0x0000837D
		public Coroutine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x00042AB8 File Offset: 0x00040CB8
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x0000A186 File Offset: 0x00008386
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCoroutine_Private_Static_Void_IntPtr_0;
	}
}
