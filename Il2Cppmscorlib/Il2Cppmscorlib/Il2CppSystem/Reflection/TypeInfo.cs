using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BE RID: 446
	[Serializable]
	public class TypeInfo : Type
	{
		// Token: 0x06001C5B RID: 7259 RVA: 0x000A1688 File Offset: 0x0009F888
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInfo()
		{
			Il2CppClassPointerStore<TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr);
			TypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100668023);
			TypeInfo.NativeMethodInfoPtr_System_Reflection_IReflectableType_GetTypeInfo_Private_Virtual_Final_New_TypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100668024);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000A16E0 File Offset: 0x0009F8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317363, RefRangeEnd = 317364, XrefRangeStart = 317359, XrefRangeEnd = 317363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000A171C File Offset: 0x0009F91C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeInfo System_Reflection_IReflectableType_GetTypeInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr_System_Reflection_IReflectableType_GetTypeInfo_Private_Virtual_Final_New_TypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInfo>(intPtr3) : null;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00009C3D File Offset: 0x00007E3D
		public TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_System_Reflection_IReflectableType_GetTypeInfo_Private_Virtual_Final_New_TypeInfo_0;
	}
}
