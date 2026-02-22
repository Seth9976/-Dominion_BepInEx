using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000150 RID: 336
	[StructLayout(2)]
	public struct PlayableGraph
	{
		// Token: 0x0600198C RID: 6540 RVA: 0x0005D100 File Offset: 0x0005B300
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableGraph()
		{
			Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr);
			PlayableGraph.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Handle");
			PlayableGraph.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Version");
			PlayableGraph.Create_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Create_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Create_Injected");
			PlayableGraph.Destroy_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Destroy_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Destroy_Injected");
			PlayableGraph.IsValid_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsValid_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::IsValid_Injected");
			PlayableGraph.IsPlaying_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsPlaying_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::IsPlaying_Injected");
			PlayableGraph.IsDone_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsDone_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::IsDone_Injected");
			PlayableGraph.Play_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Play_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Play_Injected");
			PlayableGraph.Stop_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Stop_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Stop_Injected");
			PlayableGraph.Evaluate_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Evaluate_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Evaluate_Injected");
			PlayableGraph.GetTimeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetTimeUpdateMode_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetTimeUpdateMode_Injected");
			PlayableGraph.SetTimeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.SetTimeUpdateMode_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::SetTimeUpdateMode_Injected");
			PlayableGraph.GetResolver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetResolver_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetResolver_Injected");
			PlayableGraph.SetResolver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.SetResolver_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::SetResolver_Injected");
			PlayableGraph.GetPlayableCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetPlayableCount_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetPlayableCount_Injected");
			PlayableGraph.GetRootPlayableCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetRootPlayableCount_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetRootPlayableCount_Injected");
			PlayableGraph.GetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCount_Injected");
			PlayableGraph.CreatePlayableHandle_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.CreatePlayableHandle_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::CreatePlayableHandle_Injected");
			PlayableGraph.CreateScriptOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.CreateScriptOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::CreateScriptOutputInternal_Injected");
			PlayableGraph.GetRootPlayableInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetRootPlayableInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetRootPlayableInternal_Injected");
			PlayableGraph.DestroyOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyOutputInternal_Injected");
			PlayableGraph.GetOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputInternal_Injected");
			PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCountByTypeInternal_Injected");
			PlayableGraph.GetOutputByTypeInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputByTypeInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputByTypeInternal_Injected");
			PlayableGraph.ConnectInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.ConnectInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::ConnectInternal_Injected");
			PlayableGraph.DisconnectInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DisconnectInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DisconnectInternal_Injected");
			PlayableGraph.DestroyPlayableInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyPlayableInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyPlayableInternal_Injected");
			PlayableGraph.DestroySubgraphInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroySubgraphInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroySubgraphInternal_Injected");
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, ref this));
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0005D2E0 File Offset: 0x0005B4E0
		public Playable GetRootPlayable(int index)
		{
			PlayableHandle rootPlayableInternal = this.GetRootPlayableInternal(index);
			return new Playable(rootPlayableInternal);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0005D300 File Offset: 0x0005B500
		public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : struct where V : struct
		{
			return this.ConnectInternal(source.GetHandle(), sourceOutputPort, destination.GetHandle(), destinationInputPort);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0000E2F2 File Offset: 0x0000C4F2
		public void Disconnect<U>(U input, int inputPort) where U : struct
		{
			this.DisconnectInternal(input.GetHandle(), inputPort);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0000E30A File Offset: 0x0000C50A
		public void DestroyPlayable<U>(U playable) where U : struct
		{
			this.DestroyPlayableInternal(playable.GetHandle());
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0000E321 File Offset: 0x0000C521
		public void DestroySubgraph<U>(U playable) where U : struct
		{
			this.DestroySubgraphInternal(playable.GetHandle());
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0000E338 File Offset: 0x0000C538
		public void DestroyOutput<U>(U output) where U : struct
		{
			this.DestroyOutputInternal(output.GetHandle());
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0005D338 File Offset: 0x0005B538
		public int GetOutputCountByType<T>() where T : struct
		{
			return this.GetOutputCountByTypeInternal(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0005D35C File Offset: 0x0005B55C
		public PlayableOutput GetOutput(int index)
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !this.GetOutputInternal(index, out playableOutputHandle);
			PlayableOutput playableOutput;
			if (flag)
			{
				playableOutput = PlayableOutput.Null;
			}
			else
			{
				playableOutput = new PlayableOutput(playableOutputHandle);
			}
			return playableOutput;
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0005D38C File Offset: 0x0005B58C
		public PlayableOutput GetOutputByType<T>(int index) where T : struct
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !this.GetOutputByTypeInternal(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), index, out playableOutputHandle);
			PlayableOutput playableOutput;
			if (flag)
			{
				playableOutput = PlayableOutput.Null;
			}
			else
			{
				playableOutput = new PlayableOutput(playableOutputHandle);
			}
			return playableOutput;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0000E34F File Offset: 0x0000C54F
		public void Evaluate()
		{
			this.Evaluate(0f);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0005D3C8 File Offset: 0x0005B5C8
		public static PlayableGraph Create()
		{
			return PlayableGraph.Create(null);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0005D3E0 File Offset: 0x0005B5E0
		public static PlayableGraph Create(string name)
		{
			PlayableGraph playableGraph;
			PlayableGraph.Create_Injected(name, out playableGraph);
			return playableGraph;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0000E35E File Offset: 0x0000C55E
		public void Destroy()
		{
			PlayableGraph.Destroy_Injected(ref this);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0000E366 File Offset: 0x0000C566
		public bool IsValid()
		{
			return PlayableGraph.IsValid_Injected(ref this);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0000E36E File Offset: 0x0000C56E
		public bool IsPlaying()
		{
			return PlayableGraph.IsPlaying_Injected(ref this);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0000E376 File Offset: 0x0000C576
		public bool IsDone()
		{
			return PlayableGraph.IsDone_Injected(ref this);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0000E37E File Offset: 0x0000C57E
		public void Play()
		{
			PlayableGraph.Play_Injected(ref this);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0000E386 File Offset: 0x0000C586
		public void Stop()
		{
			PlayableGraph.Stop_Injected(ref this);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0000E38E File Offset: 0x0000C58E
		public void Evaluate(float deltaTime)
		{
			PlayableGraph.Evaluate_Injected(ref this, deltaTime);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0000E397 File Offset: 0x0000C597
		public DirectorUpdateMode GetTimeUpdateMode()
		{
			return PlayableGraph.GetTimeUpdateMode_Injected(ref this);
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0000E39F File Offset: 0x0000C59F
		public void SetTimeUpdateMode(DirectorUpdateMode value)
		{
			PlayableGraph.SetTimeUpdateMode_Injected(ref this, value);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		public IExposedPropertyTable GetResolver()
		{
			return PlayableGraph.GetResolver_Injected(ref this);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		public void SetResolver(IExposedPropertyTable value)
		{
			PlayableGraph.SetResolver_Injected(ref this, value);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0000E3B9 File Offset: 0x0000C5B9
		public int GetPlayableCount()
		{
			return PlayableGraph.GetPlayableCount_Injected(ref this);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0000E3C1 File Offset: 0x0000C5C1
		public int GetRootPlayableCount()
		{
			return PlayableGraph.GetRootPlayableCount_Injected(ref this);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0000E3C9 File Offset: 0x0000C5C9
		public int GetOutputCount()
		{
			return PlayableGraph.GetOutputCount_Injected(ref this);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0005D3F8 File Offset: 0x0005B5F8
		public PlayableHandle CreatePlayableHandle()
		{
			PlayableHandle playableHandle;
			PlayableGraph.CreatePlayableHandle_Injected(ref this, out playableHandle);
			return playableHandle;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0000E3D1 File Offset: 0x0000C5D1
		public bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
		{
			return PlayableGraph.CreateScriptOutputInternal_Injected(ref this, name, out handle);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0005D410 File Offset: 0x0005B610
		public PlayableHandle GetRootPlayableInternal(int index)
		{
			PlayableHandle playableHandle;
			PlayableGraph.GetRootPlayableInternal_Injected(ref this, index, out playableHandle);
			return playableHandle;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0000E3DB File Offset: 0x0000C5DB
		public void DestroyOutputInternal(PlayableOutputHandle handle)
		{
			PlayableGraph.DestroyOutputInternal_Injected(ref this, ref handle);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0000E3E5 File Offset: 0x0000C5E5
		public bool GetOutputInternal(int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputInternal_Injected(ref this, index, out handle);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x0000E3EF File Offset: 0x0000C5EF
		public int GetOutputCountByTypeInternal(Type outputType)
		{
			return PlayableGraph.GetOutputCountByTypeInternal_Injected(ref this, outputType);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0000E3F8 File Offset: 0x0000C5F8
		public bool GetOutputByTypeInternal(Type outputType, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputByTypeInternal_Injected(ref this, outputType, index, out handle);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0000E403 File Offset: 0x0000C603
		public bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
		{
			return PlayableGraph.ConnectInternal_Injected(ref this, ref source, sourceOutputPort, ref destination, destinationInputPort);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0000E412 File Offset: 0x0000C612
		public void DisconnectInternal(PlayableHandle playable, int inputPort)
		{
			PlayableGraph.DisconnectInternal_Injected(ref this, ref playable, inputPort);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0000E41D File Offset: 0x0000C61D
		public void DestroyPlayableInternal(PlayableHandle playable)
		{
			PlayableGraph.DestroyPlayableInternal_Injected(ref this, ref playable);
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0000E427 File Offset: 0x0000C627
		public void DestroySubgraphInternal(PlayableHandle playable)
		{
			PlayableGraph.DestroySubgraphInternal_Injected(ref this, ref playable);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0000E431 File Offset: 0x0000C631
		public static void Create_Injected(string name, out PlayableGraph ret)
		{
			PlayableGraph.Create_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0000E444 File Offset: 0x0000C644
		public static void Destroy_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Destroy_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0000E451 File Offset: 0x0000C651
		public static bool IsValid_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.IsValid_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0000E45E File Offset: 0x0000C65E
		public static bool IsPlaying_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.IsPlaying_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0000E46B File Offset: 0x0000C66B
		public static bool IsDone_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.IsDone_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0000E478 File Offset: 0x0000C678
		public static void Play_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Play_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0000E485 File Offset: 0x0000C685
		public static void Stop_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Stop_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0000E492 File Offset: 0x0000C692
		public static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime)
		{
			PlayableGraph.Evaluate_InjectedDelegateField(ref _unity_self, deltaTime);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0000E4A0 File Offset: 0x0000C6A0
		public static DirectorUpdateMode GetTimeUpdateMode_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetTimeUpdateMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0000E4AD File Offset: 0x0000C6AD
		public static void SetTimeUpdateMode_Injected(ref PlayableGraph _unity_self, DirectorUpdateMode value)
		{
			PlayableGraph.SetTimeUpdateMode_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0005D428 File Offset: 0x0005B628
		public static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self)
		{
			IntPtr intPtr = PlayableGraph.GetResolver_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IExposedPropertyTable>(intPtr2) : null;
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0000E4BB File Offset: 0x0000C6BB
		public static void SetResolver_Injected(ref PlayableGraph _unity_self, IExposedPropertyTable value)
		{
			PlayableGraph.SetResolver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0000E4CE File Offset: 0x0000C6CE
		public static int GetPlayableCount_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetPlayableCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0000E4DB File Offset: 0x0000C6DB
		public static int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetRootPlayableCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0000E4E8 File Offset: 0x0000C6E8
		public static int GetOutputCount_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetOutputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0000E4F5 File Offset: 0x0000C6F5
		public static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret)
		{
			PlayableGraph.CreatePlayableHandle_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0000E503 File Offset: 0x0000C703
		public static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle)
		{
			return PlayableGraph.CreateScriptOutputInternal_InjectedDelegateField(ref _unity_self, IL2CPP.ManagedStringToIl2Cpp(name), out handle);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0000E517 File Offset: 0x0000C717
		public static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret)
		{
			PlayableGraph.GetRootPlayableInternal_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0000E526 File Offset: 0x0000C726
		public static void DestroyOutputInternal_Injected(ref PlayableGraph _unity_self, ref PlayableOutputHandle handle)
		{
			PlayableGraph.DestroyOutputInternal_InjectedDelegateField(ref _unity_self, ref handle);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0000E534 File Offset: 0x0000C734
		public static bool GetOutputInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputInternal_InjectedDelegateField(ref _unity_self, index, out handle);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0000E543 File Offset: 0x0000C743
		public static int GetOutputCountByTypeInternal_Injected(ref PlayableGraph _unity_self, Type outputType)
		{
			return PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(outputType));
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x0000E556 File Offset: 0x0000C756
		public static bool GetOutputByTypeInternal_Injected(ref PlayableGraph _unity_self, Type outputType, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputByTypeInternal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(outputType), index, out handle);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0000E56B File Offset: 0x0000C76B
		public static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort)
		{
			return PlayableGraph.ConnectInternal_InjectedDelegateField(ref _unity_self, ref source, sourceOutputPort, ref destination, destinationInputPort);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0000E57D File Offset: 0x0000C77D
		public static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable, int inputPort)
		{
			PlayableGraph.DisconnectInternal_InjectedDelegateField(ref _unity_self, ref playable, inputPort);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x0000E58C File Offset: 0x0000C78C
		public static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable)
		{
			PlayableGraph.DestroyPlayableInternal_InjectedDelegateField(ref _unity_self, ref playable);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x0000E59A File Offset: 0x0000C79A
		public static void DestroySubgraphInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable)
		{
			PlayableGraph.DestroySubgraphInternal_InjectedDelegateField(ref _unity_self, ref playable);
		}

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x040012B8 RID: 4792
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x040012B9 RID: 4793
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x040012BA RID: 4794
		private static readonly PlayableGraph.Create_InjectedDelegate Create_InjectedDelegateField;

		// Token: 0x040012BB RID: 4795
		private static readonly PlayableGraph.Destroy_InjectedDelegate Destroy_InjectedDelegateField;

		// Token: 0x040012BC RID: 4796
		private static readonly PlayableGraph.IsValid_InjectedDelegate IsValid_InjectedDelegateField;

		// Token: 0x040012BD RID: 4797
		private static readonly PlayableGraph.IsPlaying_InjectedDelegate IsPlaying_InjectedDelegateField;

		// Token: 0x040012BE RID: 4798
		private static readonly PlayableGraph.IsDone_InjectedDelegate IsDone_InjectedDelegateField;

		// Token: 0x040012BF RID: 4799
		private static readonly PlayableGraph.Play_InjectedDelegate Play_InjectedDelegateField;

		// Token: 0x040012C0 RID: 4800
		private static readonly PlayableGraph.Stop_InjectedDelegate Stop_InjectedDelegateField;

		// Token: 0x040012C1 RID: 4801
		private static readonly PlayableGraph.Evaluate_InjectedDelegate Evaluate_InjectedDelegateField;

		// Token: 0x040012C2 RID: 4802
		private static readonly PlayableGraph.GetTimeUpdateMode_InjectedDelegate GetTimeUpdateMode_InjectedDelegateField;

		// Token: 0x040012C3 RID: 4803
		private static readonly PlayableGraph.SetTimeUpdateMode_InjectedDelegate SetTimeUpdateMode_InjectedDelegateField;

		// Token: 0x040012C4 RID: 4804
		private static readonly PlayableGraph.GetResolver_InjectedDelegate GetResolver_InjectedDelegateField;

		// Token: 0x040012C5 RID: 4805
		private static readonly PlayableGraph.SetResolver_InjectedDelegate SetResolver_InjectedDelegateField;

		// Token: 0x040012C6 RID: 4806
		private static readonly PlayableGraph.GetPlayableCount_InjectedDelegate GetPlayableCount_InjectedDelegateField;

		// Token: 0x040012C7 RID: 4807
		private static readonly PlayableGraph.GetRootPlayableCount_InjectedDelegate GetRootPlayableCount_InjectedDelegateField;

		// Token: 0x040012C8 RID: 4808
		private static readonly PlayableGraph.GetOutputCount_InjectedDelegate GetOutputCount_InjectedDelegateField;

		// Token: 0x040012C9 RID: 4809
		private static readonly PlayableGraph.CreatePlayableHandle_InjectedDelegate CreatePlayableHandle_InjectedDelegateField;

		// Token: 0x040012CA RID: 4810
		private static readonly PlayableGraph.CreateScriptOutputInternal_InjectedDelegate CreateScriptOutputInternal_InjectedDelegateField;

		// Token: 0x040012CB RID: 4811
		private static readonly PlayableGraph.GetRootPlayableInternal_InjectedDelegate GetRootPlayableInternal_InjectedDelegateField;

		// Token: 0x040012CC RID: 4812
		private static readonly PlayableGraph.DestroyOutputInternal_InjectedDelegate DestroyOutputInternal_InjectedDelegateField;

		// Token: 0x040012CD RID: 4813
		private static readonly PlayableGraph.GetOutputInternal_InjectedDelegate GetOutputInternal_InjectedDelegateField;

		// Token: 0x040012CE RID: 4814
		private static readonly PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegate GetOutputCountByTypeInternal_InjectedDelegateField;

		// Token: 0x040012CF RID: 4815
		private static readonly PlayableGraph.GetOutputByTypeInternal_InjectedDelegate GetOutputByTypeInternal_InjectedDelegateField;

		// Token: 0x040012D0 RID: 4816
		private static readonly PlayableGraph.ConnectInternal_InjectedDelegate ConnectInternal_InjectedDelegateField;

		// Token: 0x040012D1 RID: 4817
		private static readonly PlayableGraph.DisconnectInternal_InjectedDelegate DisconnectInternal_InjectedDelegateField;

		// Token: 0x040012D2 RID: 4818
		private static readonly PlayableGraph.DestroyPlayableInternal_InjectedDelegate DestroyPlayableInternal_InjectedDelegateField;

		// Token: 0x040012D3 RID: 4819
		private static readonly PlayableGraph.DestroySubgraphInternal_InjectedDelegate DestroySubgraphInternal_InjectedDelegateField;

		// Token: 0x020009AF RID: 2479
		// (Invoke) Token: 0x0600317E RID: 12670
		private delegate void Create_InjectedDelegate(IntPtr name, [Out] IntPtr ret);

		// Token: 0x020009B0 RID: 2480
		// (Invoke) Token: 0x06003180 RID: 12672
		private delegate void Destroy_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009B1 RID: 2481
		// (Invoke) Token: 0x06003182 RID: 12674
		private delegate bool IsValid_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009B2 RID: 2482
		// (Invoke) Token: 0x06003184 RID: 12676
		private delegate bool IsPlaying_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009B3 RID: 2483
		// (Invoke) Token: 0x06003186 RID: 12678
		private delegate bool IsDone_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009B4 RID: 2484
		// (Invoke) Token: 0x06003188 RID: 12680
		private delegate void Play_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009B5 RID: 2485
		// (Invoke) Token: 0x0600318A RID: 12682
		private delegate void Stop_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009B6 RID: 2486
		// (Invoke) Token: 0x0600318C RID: 12684
		private delegate void Evaluate_InjectedDelegate(IntPtr _unity_self, float deltaTime);

		// Token: 0x020009B7 RID: 2487
		// (Invoke) Token: 0x0600318E RID: 12686
		private delegate DirectorUpdateMode GetTimeUpdateMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009B8 RID: 2488
		// (Invoke) Token: 0x06003190 RID: 12688
		private delegate void SetTimeUpdateMode_InjectedDelegate(IntPtr _unity_self, DirectorUpdateMode value);

		// Token: 0x020009B9 RID: 2489
		// (Invoke) Token: 0x06003192 RID: 12690
		private delegate IntPtr GetResolver_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009BA RID: 2490
		// (Invoke) Token: 0x06003194 RID: 12692
		private delegate void SetResolver_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x020009BB RID: 2491
		// (Invoke) Token: 0x06003196 RID: 12694
		private delegate int GetPlayableCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009BC RID: 2492
		// (Invoke) Token: 0x06003198 RID: 12696
		private delegate int GetRootPlayableCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009BD RID: 2493
		// (Invoke) Token: 0x0600319A RID: 12698
		private delegate int GetOutputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009BE RID: 2494
		// (Invoke) Token: 0x0600319C RID: 12700
		private delegate void CreatePlayableHandle_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020009BF RID: 2495
		// (Invoke) Token: 0x0600319E RID: 12702
		private delegate bool CreateScriptOutputInternal_InjectedDelegate(IntPtr _unity_self, IntPtr name, [Out] IntPtr handle);

		// Token: 0x020009C0 RID: 2496
		// (Invoke) Token: 0x060031A0 RID: 12704
		private delegate void GetRootPlayableInternal_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);

		// Token: 0x020009C1 RID: 2497
		// (Invoke) Token: 0x060031A2 RID: 12706
		private delegate void DestroyOutputInternal_InjectedDelegate(IntPtr _unity_self, IntPtr handle);

		// Token: 0x020009C2 RID: 2498
		// (Invoke) Token: 0x060031A4 RID: 12708
		private delegate bool GetOutputInternal_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr handle);

		// Token: 0x020009C3 RID: 2499
		// (Invoke) Token: 0x060031A6 RID: 12710
		private delegate int GetOutputCountByTypeInternal_InjectedDelegate(IntPtr _unity_self, IntPtr outputType);

		// Token: 0x020009C4 RID: 2500
		// (Invoke) Token: 0x060031A8 RID: 12712
		private delegate bool GetOutputByTypeInternal_InjectedDelegate(IntPtr _unity_self, IntPtr outputType, int index, [Out] IntPtr handle);

		// Token: 0x020009C5 RID: 2501
		// (Invoke) Token: 0x060031AA RID: 12714
		private delegate bool ConnectInternal_InjectedDelegate(IntPtr _unity_self, IntPtr source, int sourceOutputPort, IntPtr destination, int destinationInputPort);

		// Token: 0x020009C6 RID: 2502
		// (Invoke) Token: 0x060031AC RID: 12716
		private delegate void DisconnectInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable, int inputPort);

		// Token: 0x020009C7 RID: 2503
		// (Invoke) Token: 0x060031AE RID: 12718
		private delegate void DestroyPlayableInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable);

		// Token: 0x020009C8 RID: 2504
		// (Invoke) Token: 0x060031B0 RID: 12720
		private delegate void DestroySubgraphInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable);
	}
}
