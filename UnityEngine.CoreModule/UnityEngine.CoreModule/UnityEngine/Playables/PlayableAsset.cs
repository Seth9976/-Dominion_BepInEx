using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Playables
{
	// Token: 0x0200014D RID: 333
	[Serializable]
	public class PlayableAsset : ScriptableObject
	{
		// Token: 0x0600195C RID: 6492 RVA: 0x0005C7C4 File Offset: 0x0005A9C4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableAsset()
		{
			Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr);
			PlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100665189);
			PlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100665190);
			PlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100665191);
			PlayableAsset.NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100665192);
			PlayableAsset.NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100665193);
			PlayableAsset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100665194);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0005C86C File Offset: 0x0005AA6C
		[CallerCount(0)]
		public unsafe virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x0005C8D4 File Offset: 0x0005AAD4
		public unsafe virtual double duration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82689, XrefRangeEnd = 82693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x0005C91C File Offset: 0x0005AB1C
		public unsafe virtual IEnumerable<PlayableBinding> outputs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82693, XrefRangeEnd = 82697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0005C968 File Offset: 0x0005AB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82697, XrefRangeEnd = 82719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graph;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x0005C9CC File Offset: 0x0005ABCC
		[CallerCount(0)]
		public unsafe static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptrToDouble;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x0005CA10 File Offset: 0x0005AC10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82720, RefRangeEnd = 82724, XrefRangeStart = 82719, XrefRangeEnd = 82720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0000E1F7 File Offset: 0x0000C3F7
		public PlayableAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
